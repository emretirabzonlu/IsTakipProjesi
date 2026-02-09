using IsTakip.Business;
using IsTakip.DataAccess;
using IsTakip.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjeController : ControllerBase
    {
        private readonly IsTakipContext _context;

        public ProjeController(IsTakipContext context)
        {
            _context = context;
        }

        // 1. TÜM PROJELERİ GETİR
        // GET: api/Proje
        [HttpGet]
        public async Task<IActionResult> GetProjeler()
        {
            var projeler = await _context.Projeler
                .Include(p => p.Musteri) // Projenin müşterisini de getir
                .ToListAsync();

            return Ok(projeler);
        }

        // 2. YENİ PROJE EKLE
        // POST: api/Proje
        [HttpPost]
        public async Task<IActionResult> ProjeEkle(Proje proje)
        {
            // Tarihler boş gelirse bugünün tarihini atayalım
            if (proje.BaslangicTarihi == DateTime.MinValue)
                proje.BaslangicTarihi = DateTime.Now;

            _context.Projeler.Add(proje);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProjeler), new { id = proje.Id }, proje);
        }

        // 3. PROJE SİL (Lazım olur)
        [HttpDelete("{id}")]
        public async Task<IActionResult> ProjeSil(int id)
        {
            var proje = await _context.Projeler.FindAsync(id);
            if (proje == null) return NotFound("Proje bulunamadı");

            _context.Projeler.Remove(proje);
            await _context.SaveChangesAsync();
            return Ok("Proje silindi.");
        }
    }
}