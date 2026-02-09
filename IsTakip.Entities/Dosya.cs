using System;
using System.Text.Json.Serialization;

namespace IsTakip.Entities
{
    public class Dosya : BaseEntity
    {
        public string DosyaAdi { get; set; }
        public string DosyaYolu { get; set; }
        public string Uzanti { get; set; }
        public DateTime YuklemeTarihi { get; set; } = DateTime.Now;

        public int GorevId { get; set; }
        [JsonIgnore]
        public virtual Gorev? Gorev { get; set; }

        public int YukleyenPersonelId { get; set; }
    }
}