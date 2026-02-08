using Microsoft.AspNetCore.Mvc;
using IsTakip.Business.Abstract;
using IsTakip.Entities;

namespace IsTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmanController : ControllerBase
    {
        private readonly IDepartmanService _departmanService;

        public DepartmanController(IDepartmanService departmanService)
        {
            _departmanService = departmanService;
        }

        [HttpPost]
        public IActionResult Ekle(Departman d)
        {
            _departmanService.Ekle(d);
            return Ok("Departman Eklendi");
        }

        [HttpGet]
        public IActionResult Listele()
        {
            return Ok(_departmanService.Listele());
        }
    }
}