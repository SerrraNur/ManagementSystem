using FluentValidation;
using EntityLayer.Concrete;


namespace Core_ManagementSystem.Models
{
    public class LoginViewModelValidator : AbstractValidator<LoginViewModel>
    {
        public LoginViewModelValidator()
        {
            RuleFor(x => x.User_Name)
                .NotEmpty().WithMessage("Username is required.")
                .Length(3, 20).WithMessage("Username must be between 3 and 20 characters.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .Length(6, 20).WithMessage("Password must be between 6 and 20 characters.");
        }
    }
}