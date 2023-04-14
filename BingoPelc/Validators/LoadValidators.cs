using BingoPelc.Models;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace BingoPelc.Validators;

public static class LoadValidators
{
    public static IServiceCollection AddValidators(this IServiceCollection services)
    { 
        services.AddFluentValidationAutoValidation();
        
        services.AddScoped<IValidator<RegisterUserWithPasswordDto>, RegisterWithPasswordDtoValidator>();
        
        return services;
    }
}