using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Core_ManagementSystem.Models;
using FluentValidation;
using FluentValidation.Results;

namespace Core_ManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        // Login sayfası
        public ActionResult Index()
        {
            ViewData["Title"] = "Login Page";
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            var validator = new LoginViewModelValidator();
            ValidationResult result = validator.Validate(model);
            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                }
                return View("Index");
            }
            return RedirectToAction("Index", "Dashboard");
        }
    }
}

