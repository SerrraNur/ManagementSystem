using Microsoft.AspNetCore.Mvc;

namespace Core_ManagementSystem.Controllers
{
    public class CourseSelectionController : Controller
    {
        // Ders seçimi ana sayfası
        public ActionResult Index()
        {
            ViewData["Title"] = "Course Selection";
            return View();
        }
    }
}
