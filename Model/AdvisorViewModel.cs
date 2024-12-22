using BuisnessLayer.ValidationRules;
using Core_ManagementSystem.Models;
using EntityLayer.Concrete;
using FluentValidation;

namespace Core_ManagementSystem.Models
{
    public class AdvisorViewModel
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public Advisor Advisor { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
    }
    public class AdvisorViewModelValidator : AbstractValidator<AdvisorViewModel>
    {
        
        public AdvisorViewModelValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Danışman adı gereklidir.");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Geçerli bir e-posta adresi gereklidir.");
        }
    }
}
