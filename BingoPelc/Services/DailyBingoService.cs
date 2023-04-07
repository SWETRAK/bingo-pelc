using AutoMapper;
using BingoPelc.Entities;
using BingoPelc.Exceptions;
using BingoPelc.Models;
using BingoPelc.Services.Interfaces;
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
    
    // TODO: Add logic checking if logic exists
    public async Task<DailyBingoDto> GenerateDailyQuestions(string userIdString)
    {
        if (!Guid.TryParse(userIdString, out var userIdGuid)) throw new IncorrectGuidException();

        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userIdGuid);
        if (user is null) throw new UserNotFoundException();

        var dailCount = await _dbContext.DailyBingos.CountAsync(db => db.Date.Equals(DateTime.Today));
        if (dailCount > 0) return await GetDailyBingo(userIdString);
        
        
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
        
        var result = _mapper.Map<DailyBingoDto>(dailyBingo);
        return result;
    }
    
    public async Task<DailyBingoDto> GetDailyBingo(string userIdString)
    {
        if (!Guid.TryParse(userIdString, out var userIdGuid)) throw new IncorrectGuidException();

        var dailyBingo = await _dbContext.DailyBingos
            .Include(u => u.DailyQuestions)
            .ThenInclude(q => q.Question)
            .Where(u => u.UserId == userIdGuid && u.Date == DateTime.Today)
            .FirstOrDefaultAsync();

        if (dailyBingo is null) throw new NoDailyQuestionException();

        dailyBingo.DailyQuestions = dailyBingo.DailyQuestions.OrderBy(dq => dq.Index);

        var result = _mapper.Map<DailyBingoDto>(dailyBingo);
        return result; 
    }
    
    // TODO: Add endpoint which check and tell who win who win that
}