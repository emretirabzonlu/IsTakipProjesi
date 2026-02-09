using System;
using System.Text.Json.Serialization;

namespace IsTakip.Entities
{
    public class CalismaSuresi : BaseEntity
    {
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public string Aciklama { get; set; }
        public double ToplamSaat { get; set; }

        public int GorevId { get; set; }
        [JsonIgnore]
        public virtual Gorev? Gorev { get; set; }

        public int PersonelId { get; set; }
        [JsonIgnore]
        public virtual Personel? Personel { get; set; }
    }
}