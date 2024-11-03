using Core.Models;
using FluentValidation;

namespace Core.Validators
{
    public class RegisterModelValidator : AbstractValidator<RegisterModel>
    {
        public RegisterModelValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email is not valid.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("PhoneNumber is required.")
                .Matches(@"^\+[1-9]{1}[0-9]{3,14}$").WithMessage("PhoneNumber is not valid.");
        }
    }
}
