using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Core_ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Core_ManagementSystem.ViewComponents.Login
{
    public class LoginList : ViewComponent
    {
        LoginManager loginManager = new LoginManager(new EFLoginDal());
        UserManager userManager = new UserManager(new EFUserDal());
        RoleManager roleManager = new RoleManager(new EFRoleDal());
        StudentManager studentManager = new StudentManager(new EFStudentDal());
        AdvisorManager advisorManager = new AdvisorManager(new EFAdvisorDal());

        public IViewComponentResult Invoke()
        {
            // Login tablolarından tüm verileri al
            var logins = loginManager.TGetList();

            // ViewModel oluştur
            var loginViewModels = logins.Select(login => new LoginViewModel
            {
                Login = login,
                User = userManager.TGetById(login.UserId), // İlişkili kullanıcı
                Role = roleManager.TGetById(login.RoleId), // Kullanıcı rolü
                Student = studentManager.TGetById(login.StudentId), // Öğrenci detayı
                Advisor = advisorManager.TGetById(login.AdvisorId)  // Danışman detayı
            }).ToList();

            return View(loginViewModels);
        }
    }
}

//namespace Core_ManagementSystem.ViewComponents.Login
//{
//    public class LoginList:ViewComponent
//    {
//        LoginManager loginManager = new LoginManager(new EFLoginDal());
//        public IViewComponentResult Invoke() 
//        {
//            var values = loginManager.TGetList();
//            return View(values);
//        }
//    }
//}
