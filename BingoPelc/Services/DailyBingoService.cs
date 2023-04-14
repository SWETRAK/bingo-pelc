using AutoMapper;
using BingoPelc.Entities;
using BingoPelc.Exceptions;
using BingoPelc.Models;
using BingoPelc.Services.Interfaces;
using BingoPelc.Utils;
using Microsoft.EntityFrameworkCore;

namespace BingoPelc.Services;

public class DailyBingoService: IDailyBingoService
{
    private readonly DomainContextDb _dbContext;
    private readonly IMapper _mapper;
    private readonly ILogger<DailyBingoService> _logger;
    
    public DailyBingoService(DomainContextDb dbContext, IMapper mapper, ILogger<DailyBingoService> logger)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _logger = logger;
    }
    
    /// <summary>
    /// Method generates daily bingo for user if not exists.
    /// If it exists it returns already existing daily bingo from database 
    /// </summary>
    /// <param name="userIdString">User id in string form</param>
    /// <returns>DailyBingo object with data for specific user</returns>
    /// <exception cref="UserNotFoundException">Throws exception if user string guid is incorrect</exception>
    public async Task<DailyBingoDto> GenerateDailyBingo(string userIdString)
    {
        var userIdGuid = GuidUtil.ParseGuidFromString(userIdString);

        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userIdGuid);
        if (user is null) throw new UserNotFoundException();

        var dailCount = await _dbContext.DailyBingos.CountAsync(db => db.Date.Equals(DateTime.Today));
        
        var dailyBingo = dailCount > 0 ? 
            await GetDailyBingo(userIdGuid, DateTime.Today) : 
            await GenerateDailyBingoForUser(user);
        var result = _mapper.Map<DailyBingoDto>(dailyBingo);
        return result;
    }
    
    /// <summary>
    /// Function to get daily bingo from database for specific user
    /// </summary>
    /// <param name="userIdString">User id in string form</param>
    /// <returns>DailyBingo object with data for specific user</returns>
    /// <exception cref="NoDailyQuestionException">Throws exception if daily question is not found for user</exception>
    /// <exception cref="UserNotFoundException">Throws exception if user string guid is incorrect</exception>
    public async Task<DailyBingoDto> GetDailyBingo(string userIdString)
    {
        var userIdGuid = GuidUtil.ParseGuidFromString(userIdString);

        var dailyBingo = await GetDailyBingo(userIdGuid, DateTime.Today);
        if (dailyBingo is null) throw new NoDailyQuestionException();
        dailyBingo.DailyQuestions = dailyBingo.DailyQuestions.OrderBy(dq => dq.Index);
        _logger.LogInformation("Daily question was taken database for user {UserId}", userIdGuid.ToString());
        var result = _mapper.Map<DailyBingoDto>(dailyBingo);
        return result; 
    }

    /// <summary>
    /// Method checking if someone win bingo
    /// </summary>
    /// <param name="userIdString">User guid id in string format</param>
    /// <returns>DailyBingoDto with checked data </returns>
    public async Task<DailyBingoDto> CheckDailyBingo(string userIdString)
    {
        var userIdGuid = GuidUtil.ParseGuidFromString(userIdString);

        var dailyBingo = await GetDailyBingo(userIdGuid, DateTime.Today);
        dailyBingo.DailyQuestions = dailyBingo.DailyQuestions.OrderBy(dq => dq.Index);

        dailyBingo = CheckDailyBingoAlgorithm(dailyBingo);

        _dbContext.DailyBingos.Update(dailyBingo);
        await _dbContext.SaveChangesAsync();

        return _mapper.Map<DailyBingoDto>(dailyBingo);
    }

    private async Task<DailyBingo> GetDailyBingo(Guid userId, DateTime dateTime)
    {
        return await _dbContext.DailyBingos
            .Include(u => u.DailyQuestions)
            .ThenInclude(q => q.Question)
            .Where(u => u.UserId == userId && u.Date == dateTime)
            .FirstOrDefaultAsync();
    }

    private async Task<DailyBingo> GenerateDailyBingoForUser(User user)
    {
        var questions = await _dbContext.Questions.OrderBy(g => Guid.NewGuid()).Take(25).ToListAsync();
        var dailyBingo = new DailyBingo
        {
            Date = DateTime.Today,
            User = user
        };
        
        var dailyQuestions = questions
            .Select((q, index )=> new DailyQuestion
            {
                Question = q,
                Checked = false,
                Index = index + 1,
                DailyBingo = dailyBingo,
            })
            .ToList();
        
        dailyBingo.DailyQuestions = dailyQuestions;

        await _dbContext.DailyBingos.AddAsync(dailyBingo);
        await _dbContext.SaveChangesAsync();
        _logger.LogInformation(
            "Daily bingo for user {UserId} in {Date} created", 
            user.Id.ToString(), 
            DateTime.Now.ToString("yy-MM-dd"));
        return dailyBingo;
    }

    private static DailyBingo CheckDailyBingoAlgorithm(DailyBingo dailyBingo)
    {
        var dailyBingoDailyQuestions = 
            dailyBingo.DailyQuestions as DailyQuestion[] ?? 
            dailyBingo.DailyQuestions.ToArray();

        var win = false;
        
        for (uint i = 0; i < 5; i++)
        {
            if (
                dailyBingoDailyQuestions[0 + 5 * i].Checked &&
                dailyBingoDailyQuestions[1 + 5 * i].Checked &&
                dailyBingoDailyQuestions[2 + 5 * i].Checked &&
                dailyBingoDailyQuestions[3 + 5 * i].Checked &&
                dailyBingoDailyQuestions[4 + 5 * i].Checked
            )
            {
                win = true;
            }

            if (
                dailyBingoDailyQuestions[0 + i].Checked &&
                dailyBingoDailyQuestions[5 + i].Checked &&
                dailyBingoDailyQuestions[10 + i].Checked &&
                dailyBingoDailyQuestions[15 + i].Checked &&
                dailyBingoDailyQuestions[20 + i].Checked
            )
            {
                win = true;
            }
        }

        if (
            dailyBingoDailyQuestions[0].Checked &&
            dailyBingoDailyQuestions[6].Checked &&
            dailyBingoDailyQuestions[12].Checked &&
            dailyBingoDailyQuestions[18].Checked &&
            dailyBingoDailyQuestions[24].Checked
        )
        {
            win = true;
        }
        
        if (
            dailyBingoDailyQuestions[4].Checked &&
            dailyBingoDailyQuestions[8].Checked &&
            dailyBingoDailyQuestions[12].Checked &&
            dailyBingoDailyQuestions[16].Checked &&
            dailyBingoDailyQuestions[20].Checked
        )
        {
            win = true;
        }

        dailyBingo.Win = win;
        return dailyBingo;
    }
}