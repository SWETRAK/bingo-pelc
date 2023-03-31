using System.Security.Claims;
using BingoPelc.Exceptions;

namespace BingoPelc.Authentication;

public static class AuthenticationHelper
{
    public static string GetUserIdFromAuthCookie(ClaimsPrincipal user)
    {
        var guidId = user.Claims.ToDictionary(claim => claim.Type, claim => claim.Value)
            .FirstOrDefault(p => p.Key == ClaimTypes.NameIdentifier)
            .Value;

        if (guidId is null) throw new IncorrectGuidException();
        return guidId;
    }

    public static string GetUserNicknameFromAuthCookie(ClaimsIdentity user)
    {
        var nickname = user.Claims.ToDictionary(claim => claim.Type, claim => claim.Value)
            .FirstOrDefault(p => p.Key == ClaimTypes.Name)
            .Value;

        return nickname;
    }

    public static string GetEmailFromAuthCookie(ClaimsIdentity user)
    {
        var email = user.Claims.ToDictionary(claim => claim.Type, claim => claim.Value)
            .FirstOrDefault(p => p.Key == ClaimTypes.Email)
            .Value;

        return email;
    }
}