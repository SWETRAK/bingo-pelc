using BingoPelc.Models;

namespace BingoPelc.Services.Interfaces;

public interface IDailyQuestionService
{
    Task<DailyQuestionDto> CheckDailyQuestion(string userIdString, DailyQuestionDto questionIdString);
}