using AutoMapper;
using BingoPelc.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BingoPelc.Services;

public class DailyQuestionService: IDailyQuestionService
{
    private readonly DomainContextDb _dbContext;
    private readonly IMapper _mapper;

    public DailyQuestionService(DomainContextDb dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task CheckDailyQuestion(string userIdString, string questionIdString)
    {
        if (!Guid.TryParse(userIdString, out var userIdGuid)) throw new Exception();
        if (!Guid.TryParse(questionIdString, out var questionIdGuid)) throw new Exception();

        var question = await _dbContext.DailyQuestions.Where(q => q.Id == questionIdGuid).FirstOrDefaultAsync();

        if (question is null) throw new Exception();
        question.Checked = !question.Checked;

        _dbContext.DailyQuestions.Update(question);
        await _dbContext.SaveChangesAsync();
    }
}