using System.Runtime.CompilerServices;
using BingoPelc.Models;
using BingoPelc.Repositories;
using FluentValidation;

namespace BingoPelc.Validators;

public class RegisterWithPasswordDtoValidator: AbstractValidator<RegisterUserWithPasswordDto>
{
    private readonly UserRepository _userRepository;
    
    
    public RegisterWithPasswordDtoValidator(UserRepository userRepository)
    {
        _userRepository = userRepository;
        
        RuleFor(x => x.Email)
            .EmailAddress()
            .NotEmpty()
            .Custom(CheckUser);
        
        RuleFor(x => x.Password)
            .NotEmpty()
            .MinimumLength(8);

        RuleFor(x => x.NickName)
            .NotEmpty()
            .MinimumLength(4)
            .MaximumLength(20);
    }
    
    private async void CheckUser(string value, ValidationContext<RegisterUserWithPasswordDto> context)
    {
        var user = await _userRepository.GetByEmail(value.ToLower());
        if (user is not null) context.AddFailure("Email", "That email is taken");
    }
}