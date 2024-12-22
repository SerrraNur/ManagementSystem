using Microsoft.AspNetCore.Mvc;

namespace Core_ManagementSystem.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
    }
}
//Backend tarafındaki kodların yazıldığı yer
