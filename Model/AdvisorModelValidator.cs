
using FluentValidation;
namespace Core_ManagementSystem.Models
{
    public class AdvisorViewModelValidator : AbstractValidator<AdvisorViewModel>
    {
        public AdvisorViewModelValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Danışman adı boş olamaz.")
                .MinimumLength(3).WithMessage("Danışman adı en az 3 karakter olmalıdır.");
        }
    }
}