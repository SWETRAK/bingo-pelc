using BingoPelc.Exceptions;

namespace BingoPelc.MIddlewares;

public class ErrorMiddleware: IMiddleware
{

    private readonly ILogger _logger;
    
    public ErrorMiddleware(ILogger logger)
    {
        _logger = logger;
    }
    
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            _logger.LogInformation("Connection from {} try to reach {}", context.Connection.RemoteIpAddress,
                context.Request.Path);
            await next.Invoke(context);
        }
        catch (IncorrectGuidException incorrectGuidException)
        {
            _logger.LogInformation("Guid with incorrect form {}|{}", incorrectGuidException,
                incorrectGuidException.Message);
            context.Response.StatusCode = 400;
            await context.Response.WriteAsJsonAsync("");
        }
        catch (InvalidLoginDataException invalidLoginDataException)
        {
            _logger.LogInformation("Some one with {} email try to login unsuccessful", invalidLoginDataException.Email);
            context.Response.StatusCode = 401;
            await context.Response.WriteAsJsonAsync("");
        }
        catch (UserNotFoundException userNotFoundException)
        {
            _logger.LogInformation("Some one with {} id try to get user info", userNotFoundException.GuidString);
            context.Response.StatusCode = 401;
            await context.Response.WriteAsJsonAsync("");
        }
        catch (Exception e)
        {
            _logger.LogCritical("Unknown error {}|{}", e, e.Message);
            context.Response.StatusCode = 500;
            await context.Response.WriteAsJsonAsync("");
        }
    }
}