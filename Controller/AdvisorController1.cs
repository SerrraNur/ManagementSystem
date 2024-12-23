using Microsoft.AspNetCore.Mvc;
using Core_ManagementSystem.Models;
using System.Net.Http;
using System.Text;
using System.Text.Json;

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

        [HttpPost]
        public async Task<ActionResult> AddAdvisor(AdvisorViewModel model)
        {
            if (ModelState.IsValid)
            {
                // API'ye danışman eklemek için bir istek gönder
                using (var httpClient = new HttpClient())
                {
                    var jsonContent = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync("https://localhost:5001/api/advisors", jsonContent);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError("", "Danışman eklenirken bir hata oluştu.");
            }

            return View(model);
        }

        // GET - Tüm Danışmanları Listeleme
        [HttpGet]
        [Route("api/advisors")]
        public IActionResult GetAllAdvisors()
        {
            // Örnek bir data, burada veritabanına bağlanmayı düşünebilirsin
            var advisors = new List<AdvisorViewModel>
            {
                new AdvisorViewModel { Advisor_ID = 1, FullName = "John Doe", Email = "john@example.com" },
                new AdvisorViewModel { Advisor_ID = 2, FullName = "Jane Smith", Email = "jane@example.com" }
            };

            return Ok(advisors); // 200 OK + JSON formatında liste döner
        }

        // GET - ID ile Danışman Getirme
        [HttpGet]
        [Route("api/advisors/{id}")]
        public IActionResult GetAdvisorById(int id)
        {
            // Örnek bir data, burada veritabanı sorgusu yapılabilir
            var advisor = new AdvisorViewModel { Id = id, Name = "John Doe", Email = "john@example.com" };

            if (advisor == null)
                return NotFound(); // Danışman bulunamazsa 404 döner

            return Ok(advisor); // 200 OK + JSON formatında danışman döner
        }

        // PUT - Danışman Güncelleme
        [HttpPut]
        [Route("api/advisors/{id}")]
        public IActionResult UpdateAdvisor(int id, [FromBody] AdvisorViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Güncelleme işlemleri burada yapılabilir
                return NoContent(); // Güncelleme başarılıysa 204 döner
            }

            return BadRequest(ModelState); // Model doğrulama hatası varsa 400 döner
        }

        // DELETE - Danışman Silme
        [HttpDelete]
        [Route("api/advisors/{id}")]
        public IActionResult DeleteAdvisor(int id)
        {
            // Silme işlemi burada yapılır
            return NoContent(); // Başarılı silme işlemi sonrası 204 döner
        }
    }
}



//namespace Core_ManagementSystem.Controllers
//{
//    public class AdvisorController : Controller
//    {
//        public ActionResult Index()
//        {
//            ViewData["Title"] = "Advisor Page";
//            return View();
//        }

//        [HttpGet]
//        public ActionResult AddAdvisor()
//        {
//            ViewData["Title"] = "Add Advisor";
//            return View();
//        }

//        // Burasından emin değilim?
//        [HttpPost]
//        public ActionResult AddAdvisor(AdvisorViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                // Validasyon başarılı, burada danışmanı veritabanına ekleme işlemini yapabilirsiniz

//                return RedirectToAction("Index"); // Danışman başarıyla eklendikten sonra ana sayfaya yönlendirme
//            }
//            return View(model);
//        }
//    }
//}

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
