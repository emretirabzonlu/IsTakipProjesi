using System.Text.Json.Serialization;

namespace IsTakip.Entities
{
    public class Gorev : BaseEntity
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Durum { get; set; }

        public int PersonelId { get; set; }

        // DİKKAT: "Personel?" yaptık
        [JsonIgnore]
        public virtual Personel? Personel { get; set; }
    }
}