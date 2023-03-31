using BingoPelc.Services.Interfaces;

namespace BingoPelc.Services;

public static class LoadServices
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IDailyBingoService, DailyBingoService>();
        services.AddScoped<IDailyQuestionService, DailyQuestionService>();
    }
}