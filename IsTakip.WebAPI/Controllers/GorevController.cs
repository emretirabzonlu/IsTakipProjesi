using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IsTakip.Business.Abstract;
using IsTakip.Entities;

namespace IsTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GorevController : ControllerBase
    {
        private readonly IGorevService _gorevService;

        public GorevController(IGorevService gorevService)
        {
            _gorevService = gorevService;
        }

        [HttpGet]
        public IActionResult Listele()
        {
            return Ok(_gorevService.Listele());
        }

        [HttpPost]
        public IActionResult Ekle(Gorev g)
        {
            // Manager içinde "GorevEkle" metodunda 3 karakter kontrolü yapmıştık hatırlarsan.
            // Eğer orada bir hata fırlatıyorsak burada try-catch gerekebilir ama şimdilik basit tutalım.
            _gorevService.GorevEkle(g);
            return Ok("Görev Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Sil(int id)
        {
            var gorev = _gorevService.GetById(id);
            _gorevService.GorevSil(gorev);
            return Ok("Görev Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _gorevService.GetById(id);
            if (value == null) return NotFound("Görev bulunamadı");
            return Ok(value);
        }

        [HttpPut]
        public IActionResult Guncelle(Gorev g)
        {
            _gorevService.GorevGuncelle(g);
            return Ok("Görev Güncellendi");
        }
    }
}