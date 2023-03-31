using BingoPelc.Models;

namespace BingoPelc.Services.Interfaces;

public interface IAuthService
{
    Task<(UserInfoDto, string)> GetUserInfo(string guideId);
    Task<(UserInfoDto, string)> LoginUser(LoginUserWithPasswordDto userDto);
}