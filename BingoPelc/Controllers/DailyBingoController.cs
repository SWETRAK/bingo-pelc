using BingoPelc.Authentication;
using BingoPelc.Models;
using BingoPelc.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BingoPelc.Controllers;

[ApiController]
[Route("api/v1/bingo/daily")]
public class DailyBingoController: Controller
{

    private readonly ILogger<DailyBingoController> _logger;
    private readonly IDailyBingoService _dailyBingoService;
    
    public DailyBingoController(ILogger<DailyBingoController> logger, IDailyBingoService dailyBingoService)
    {
        _logger = logger;
        _dailyBingoService = dailyBingoService;
    }

    [Authorize]
    [HttpGet]
    public async Task<ActionResult<DailyBingoDto>> GetDailyBingo()
    {
        var userGuidId = AuthenticationHelper.GetUserIdFromAuthCookie(User);
        var dailyGuide = await _dailyBingoService.GetDailyBingo(userGuidId);
        
        return Ok(dailyGuide);
    }
    
    [Authorize]
    [HttpGet("generate")]
    public async  Task<ActionResult<DailyBingoDto>> GenerateDailyBingo()
    {
        var userGuidId = AuthenticationHelper.GetUserIdFromAuthCookie(User);
        var dailyGuide = await _dailyBingoService.GenerateDailyBingo(userGuidId);

        return Ok(dailyGuide);
    }
}