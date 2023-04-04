using BingoPelc.Authentication;
using BingoPelc.Models;
using BingoPelc.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BingoPelc.Controllers;

[ApiController]
[Route("api/v1/bingo/daily/questions")]
public class DailyQuestionController: Controller
{
    private readonly ILogger<DailyQuestionController> _logger;
    private readonly IDailyQuestionService _dailyQuestionService;

    public DailyQuestionController(
        ILogger<DailyQuestionController> logger, 
        IDailyQuestionService dailyQuestionService)
    {
        _logger = logger;
        _dailyQuestionService = dailyQuestionService;
    }

    [Authorize]
    [HttpPut]
    public async Task<ActionResult<DailyQuestionDto>> ChangeDailyQuestionStatus([FromBody] DailyQuestionDto dailyQuestionDto)
    {
        var userGuidId = AuthenticationHelper.GetUserIdFromAuthCookie(User);
        var dailyQuestionResultDto = await _dailyQuestionService.CheckDailyQuestion(userGuidId, dailyQuestionDto);

        return Ok(dailyQuestionResultDto);
    }
}