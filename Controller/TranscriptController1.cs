using Microsoft.AspNetCore.Mvc;

namespace Core_ManagementSystem.Controllers
{
    public class TranscriptController : Controller
    {
        // Transcript ana sayfası
        public ActionResult Index()
        {
            ViewData["Title"] = "Transcript Page";
            return View();
        }

        // Transcript detayları (örnek)
        public ActionResult Details(int id)
        {
            // Transcript verileri (örnek)
            ViewBag.StudentName = "Ahmet Yılmaz";
            ViewBag.StudentId = id;
            ViewBag.TranscriptData = new string[] { "Math: A", "Physics: B", "History: A-" };

            return View();
        }
    }
}

//namespace Core_ManagementSystem.Controllers
