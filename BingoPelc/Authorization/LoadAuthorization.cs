using BingoPelc.Entities;
using Microsoft.AspNetCore.Identity;

namespace BingoPelc.Authorization;

public static class LoadAuthorization
{
    public static IServiceCollection AddAuthorizationCustom(this IServiceCollection services)
    {
        services.AddAuthorization((options) =>
        {
        });
        
        services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

        return services;
    }
}