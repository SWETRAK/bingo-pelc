using Microsoft.EntityFrameworkCore.Storage;

namespace BingoPelc.Middlewares;

public static class LoadMiddlewares
{
    public static IServiceCollection AddMiddlewares(this IServiceCollection services)
    {
        services.AddScoped<ErrorMiddleware>();
        return services;
    }

    public static WebApplication UseMiddlewares(this WebApplication app)
    {
        app.UseMiddleware<ErrorMiddleware>();
        return app;
    }
}