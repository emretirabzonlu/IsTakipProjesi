using System.Collections.Generic;
using System.Text.Json.Serialization; // <--- BU EKLENECEK

namespace IsTakip.Entities
{
    public class Musteri : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        // HATA VEREN YER 1: Vergi No boş olabilir diyelim (?)
        public string? VergiNo { get; set; }

        // HATA VEREN YER 2: Projeler listesi boş olabilir ve API sormasın
        [JsonIgnore]
        public virtual List<Proje>? Projeler { get; set; }
    }
}