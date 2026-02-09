using System;
using System.Text.Json.Serialization;

namespace IsTakip.Entities
{
    public class GorevYorum : BaseEntity
    {
        public string Yorum { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;

        public int GorevId { get; set; }
        [JsonIgnore]
        public virtual Gorev? Gorev { get; set; }

        public int PersonelId { get; set; }
        [JsonIgnore]
        public virtual Personel? Personel { get; set; }
    }
}