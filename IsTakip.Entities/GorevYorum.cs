using System.Text.Json.Serialization;

namespace IsTakip.Entities
{
    public class GorevYorum : BaseEntity
    {
        public string Icerik { get; set; }
        public int GorevId { get; set; }
        public int PersonelId { get; set; }

        [JsonIgnore]
        public virtual Gorev? Gorev { get; set; }
        [JsonIgnore]
        public virtual Personel? Personel { get; set; }
    }
}