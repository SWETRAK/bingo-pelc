using BingoPelc.Models;

namespace BingoPelc.Services.Interfaces;

public interface IDailyBingoService
{
    Task<DailyBingoDto> GenerateDailyQuestions(string userIdString);
    Task<DailyBingoDto> GetDailyBingo(string userIdString);
}