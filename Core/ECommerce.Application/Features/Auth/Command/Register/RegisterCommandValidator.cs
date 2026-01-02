using FluentValidation;

namespace ECommerce.Application.Features.Auth.Command.Register
{
    public class RegisterCommandValidator: AbstractValidator<RegisterCommandRequest>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x=>x.FullName)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(2)
                .WithName("Name Surname");

            RuleFor(x=>x.Email)
                .NotEmpty()
                .EmailAddress()
                .MaximumLength(60)
                .MinimumLength(8)
                .WithName("Email Address");

            RuleFor(x=>x.Password)
                .NotEmpty()
                .MinimumLength(6)
                .WithName("Password");

            RuleFor(x=>x.ConfirmedPassword)
                .NotEmpty()
                .MinimumLength(6)
                .Equal(x=>x.Password)
                .WithName("Confirmed Password");
        }
    }
}
