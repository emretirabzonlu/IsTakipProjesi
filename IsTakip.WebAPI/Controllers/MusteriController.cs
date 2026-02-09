using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IsTakip.Business.Abstract;
using IsTakip.Entities;

namespace IsTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriController : ControllerBase
    {
        private readonly IMusteriService _musteriService;

        public MusteriController(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }

        [HttpGet]
        public IActionResult Listele()
        {
            var values = _musteriService.Listele();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Ekle(Musteri m)
        {
            _musteriService.MusteriEkle(m);
            return Ok("Müşteri Başarıyla Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Sil(int id)
        {
            var value = _musteriService.GetById(id);
            if (value == null) return NotFound("Müşteri bulunamadı");

            _musteriService.MusteriSil(value);
            return Ok("Müşteri Silindi");
        }

        // Güncelleme metodu da ekleyelim tam olsun
        [HttpPut]
        public IActionResult Guncelle(Musteri m)
        {
            _musteriService.MusteriGuncelle(m);
            return Ok("Müşteri Güncellendi");
        }
    }
}