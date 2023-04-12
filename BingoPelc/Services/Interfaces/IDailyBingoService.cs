using BingoPelc.Models;

namespace BingoPelc.Services.Interfaces;

public interface IDailyBingoService
{
    Task<DailyBingoDto> GenerateDailyBingo(string userIdString);
    Task<DailyBingoDto> GetDailyBingo(string userIdString);
    Task<DailyBingoDto> CheckDailyBingo(string userIdString);
}