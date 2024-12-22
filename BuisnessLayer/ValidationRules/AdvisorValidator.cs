using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class AdvisorViewModel
    {
        public string FullName { get; set; }
    public class AdvisorViewModelValidator:AbstractValidator<Advisor>
    {
        //ctor diyip enter yapınca geliyo,nasıl olduğunu tam anlamadım?
        public AdvisorViewModelValidator()
        {
            RuleFor(x => x.FullName)
            .NotEmpty().WithMessage("Danışman adı boş olamaz.")
            .MinimumLength(3).WithMessage("Danışman adı en az 3 karakter olmalıdır.");


        }
    }
}
