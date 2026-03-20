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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _departmanService.GetById(id);
            if (value == null) return NotFound("Departman bulunamadı");
            return Ok(value);
        }

        [HttpPut]
        public IActionResult Guncelle(Departman d)
        {
            _departmanService.Guncelle(d);
            return Ok("Departman Güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Sil(int id)
        {
            var value = _departmanService.GetById(id);
            if (value == null) return NotFound("Departman bulunamadı");
            _departmanService.Sil(value);
            return Ok("Departman Silindi");
        }
    }
}