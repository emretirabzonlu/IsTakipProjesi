using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IsTakip.Business.Abstract; // Müdürlere buradan ulaşıyoruz
using IsTakip.Entities;          // Personel tablosunu buradan biliyoruz

namespace IsTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        // 1. Müdürümüzü tanımlıyoruz (Dependency Injection)
        private readonly IPersonelService _personelService;

        public PersonelController(IPersonelService personelService)
        {
            _personelService = personelService;
        }

        // 2. Listeleme İsteği (GET)
        [HttpGet]
        public IActionResult Listele()
        {
            var values = _personelService.Listele();
            return Ok(values);
        }

        // 3. Ekleme İsteği (POST) - Şimdilik bonus olsun :)
        [HttpPost]
        public IActionResult Ekle(Personel p)
        {
            _personelService.PersonelEkle(p);
            return Ok("Personel Başarıyla Eklendi");
        }
    }
}