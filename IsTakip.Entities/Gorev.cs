using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IsTakip.Entities
{
    public class Gorev : BaseEntity
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }

        // ESKİ: public string Durum { get; set; }
        // YENİ: Foreign Key ile tutalım
        public int GorevDurumId { get; set; }
        [JsonIgnore]
        public virtual GorevDurum? GorevDurum { get; set; }

        public int PersonelId { get; set; }
        [JsonIgnore]
        public virtual Personel? Personel { get; set; }

        // Yorumlar
        [JsonIgnore]
        public virtual List<GorevYorum>? Yorumlar { get; set; }
    }
}