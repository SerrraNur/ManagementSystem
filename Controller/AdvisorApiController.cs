using Microsoft.AspNetCore.Mvc;
using Core_ManagementSystem.Models;
using EntityLayer.Concrete;

namespace Core_ManagementSystem.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvisorApiController : ControllerBase
    {
        private readonly DbContext _context;

        public AdvisorApiController(DbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddAdvisor([FromBody] AdvisorViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Veritabanına ekleme işlemi burada yapılır
                var advisor = new Advisor
                {
                    FullName = model.FullName,
                    Email = model.Email
                };
                _context.Advisors.Add(advisor);
                _context.SaveChanges();

                return Ok(new { message = "Danışman başarıyla eklendi." });
            }

            return BadRequest("Geçersiz veri.");
        }
    }
}
