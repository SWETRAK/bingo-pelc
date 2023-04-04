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
    
    // TODO: Check if that works properly
    public async Task<DailyBingoDto> GenerateDailyQuestions(string userIdString)
    {
        if (!Guid.TryParse(userIdString, out var userIdGuid)) throw new IncorrectGuidException();
        
        var questions = await _dbContext.Questions.OrderBy(g => Guid.NewGuid()).Take(25).ToListAsync();

        var dailyBingo = new DailyBingo
        {
            Date = DateTime.Today,
            UserId = userIdGuid
        };
        
        var dailyQuestions = questions
            .Select((q, index )=> new DailyQuestion
                {
                    Question = q,
                    Checked = false,
                    Index = index,
                    DailyBingo = dailyBingo,
                })
            .ToList();

        dailyBingo.DailyQuestions = dailyQuestions;

        await _dbContext.DailyBingos.AddAsync(dailyBingo);
        await _dbContext.SaveChangesAsync();
        
        var result = _mapper.Map<DailyBingoDto>(dailyBingo);
        return result; 
        
    }

    // TODO: Test this logic
    public async Task<DailyBingoDto> GetDailyBingo(string userIdString)
    {
        if (!Guid.TryParse(userIdString, out var userIdGuid)) throw new IncorrectGuidException();

        var dailyBingo = await _dbContext.DailyBingos
            .Include(u => u.DailyQuestions)
            .ThenInclude(q => q.Question)
            .Where(u => u.UserId == userIdGuid && u.Date == DateTime.Today)
            .FirstOrDefaultAsync();

        if (dailyBingo is null) throw new NoDailyQuestionException();

        var result = _mapper.Map<DailyBingoDto>(dailyBingo);
        return result; 
    }
}