using BingoPelc.Authentication;
using BingoPelc.Configs;
using BingoPelc.Models;
using BingoPelc.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BingoPelc.Controllers;

[ApiController]
[Route($"auth")]
public class AuthController: Controller
{
    private readonly IAuthService _authService;
    private readonly ILogger<AuthController> _logger;
    private readonly AuthenticationSettings _authenticationSettings;

    public AuthController(
        ILogger<AuthController> logger, 
        IAuthService authenticationService, 
        AuthenticationSettings authenticationSettings)
    {
        _logger = logger;
        _authService = authenticationService;
        _authenticationSettings = authenticationSettings;
    }

    [Authorize]
    [HttpGet("info")]
    public async Task<ActionResult<UserInfoDto>> GetLoggedUserInfo()
    {
        var userGuidId = AuthenticationHelper.GetUserIdFromAuthCookie(User);

        var result = await _authService.GetUserInfo(userGuidId);
        Response.Cookies.Append(
            "X-Access-Token", 
            result.Item2, 
            new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays)
            });
        
        return Ok(result.Item1);
    }

    [HttpPost("login")]
    public async Task<ActionResult<UserInfoDto>> LoginUserWithEmailAndPassword(
        [FromBody] LoginUserWithPasswordDto loginUserWithPasswordDto)
    {
        var result = await _authService.LoginUser(loginUserWithPasswordDto);
        Response.Cookies.Append(
            "X-Access-Token",
            result.Item2,
            new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays)
            });
        return Ok(result.Item1);
    }

    [Authorize]
    [HttpDelete("logout")]
    public ActionResult<bool> LogoutUserWithPassword()
    {
        Response.Cookies.Delete("X-Access-Token");
        return Ok(true);
    }
}