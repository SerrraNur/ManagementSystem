using Microsoft.AspNetCore.Mvc;
using Core_ManagementSystem.Models;

namespace Core_ManagementSystem.Controllers
{
    public class AdvisorController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Title"] = "Advisor Page";
            return View();
        }

        [HttpGet]
        public ActionResult AddAdvisor()
        {
            ViewData["Title"] = "Add Advisor";
            return View();
        }

        // Burasından emin değilim?
        [HttpPost]
        public ActionResult AddAdvisor(AdvisorViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Validasyon başarılı, burada danışmanı veritabanına ekleme işlemini yapabilirsiniz

                return RedirectToAction("Index"); // Danışman başarıyla eklendikten sonra ana sayfaya yönlendirme
            }
            return View(model);
        }
    }
}

//namespace Core_ManagementSystem.Controllers
//{
//    public class AdvisorController : Controller
//    {
//        // Advisor ana sayfası
//        public ActionResult Index()
//        {
//            ViewData["Title"] = "Advisor Page";
//            return View();
//        }

//        // Yeni bir advisor ekleme sayfası
//        public ActionResult AddAdvisor()
//        {
//            ViewData["Title"] = "Add Advisor";
//            return View();
//        }
//    }
//}
