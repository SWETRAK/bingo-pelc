using BingoPelc.Repositories.Interfaces;

namespace BingoPelc.Repositories;

public static class LoadRepositories
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IDailyBingoRepository, DailyBingoRepository>();
        return services;
    }
}