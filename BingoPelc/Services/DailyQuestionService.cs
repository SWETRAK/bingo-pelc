using AutoMapper;
using BingoPelc.Exceptions;
using BingoPelc.Models;
using BingoPelc.Services.Interfaces;
using BingoPelc.Utils;
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="userIdString"></param>
    /// <param name="incomingDailyQuestionDto"></param>
    /// <returns></returns>
    /// <exception cref="NoDailyQuestionException"></exception>
    public async Task<DailyQuestionDto> CheckDailyQuestion(string userIdString, DailyQuestionDto incomingDailyQuestionDto)
    {
        var userIdGuid = GuidUtil.ParseGuidFromString(userIdString);
        var questionIdGuid = GuidUtil.ParseGuidFromString(incomingDailyQuestionDto.Id);
        
        var question = await _dbContext.DailyQuestions.Where(q => q.Id == questionIdGuid ).FirstOrDefaultAsync();

        if (question is null) throw new NoDailyQuestionException();
        question.Checked = !question.Checked;

        _dbContext.DailyQuestions.Update(question);
        await _dbContext.SaveChangesAsync();

        var dailyQuestionDto = _mapper.Map<DailyQuestionDto>(question);
        return dailyQuestionDto;
    }
}