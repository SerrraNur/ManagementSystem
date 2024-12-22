using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class LoginViewModel
    {
        public string User_Name { get; set; }
        public string PasswordHash { get; set; }
    }

    public class LoginViewModelValidator:AbstractValidator<Login>
    {
        public LoginViewModelValidator()
        {
            RuleFor(x => x.User_Name).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.");
            RuleFor(x => x.PasswordHash).NotEmpty().WithMessage("Şifre boş olamaz.");

    //        RuleFor(x => x.PasswordHash)
    //.Equal(x => x.ConfirmPassword)
    //.WithMessage("Şifreler birbirini tutmuyor.");

        }
    }
}
