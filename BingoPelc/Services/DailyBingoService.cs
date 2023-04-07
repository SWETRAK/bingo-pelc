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
    /// Generates daily bingo for user if it doesn't exists, if exist it gets from database
    /// </summary>
    /// <param name="userIdString">User id in string form</param>
    /// <returns>Data with daily bingo for specific user</returns>
    /// <exception cref="UserNotFoundException">Throws exception if daily question is not found for user</exception>
    public async Task<DailyBingoDto> GenerateDailyBingo(string userIdString)
    {
        var userIdGuid = GuidUtil.ParseGuidFromString(userIdString);

        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userIdGuid);
        if (user is null) throw new UserNotFoundException();

        var dailCount = await _dbContext.DailyBingos.CountAsync(db => db.Date.Equals(DateTime.Today));
        
        var dailyBingo = dailCount > 0 ? 
            await GetDailyBingo(userIdGuid, DateTime.Now) : 
            await GenerateDailyBingoForUser(user);
        
        var result = _mapper.Map<DailyBingoDto>(dailyBingo);
        return result;
    }
    
    /// <summary>
    /// Function to get daily bingo from database for specyfic user
    /// </summary>
    /// <param name="userIdString">User id in string form</param>
    /// <returns>Data with daily bingo for specific user</returns>
    /// <exception cref="NoDailyQuestionException">Throws exception if daily question is not found for user</exception>
    public async Task<DailyBingoDto> GetDailyBingo(string userIdString)
    {
        var userIdGuid = GuidUtil.ParseGuidFromString(userIdString);

        var dailyBingo = await GetDailyBingo(userIdGuid, DateTime.Now);

        if (dailyBingo is null) throw new NoDailyQuestionException();

        dailyBingo.DailyQuestions = dailyBingo.DailyQuestions.OrderBy(dq => dq.Index);

        var result = _mapper.Map<DailyBingoDto>(dailyBingo);
        return result; 
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
        return dailyBingo;
    }
}