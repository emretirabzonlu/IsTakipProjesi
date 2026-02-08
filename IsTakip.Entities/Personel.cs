using System.Text.Json.Serialization; // Bunu eklemeyi unutma

namespace IsTakip.Entities
{
    public class Personel : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Sifre { get; set; }

        public int DepartmanId { get; set; }

        // DİKKAT: "Departman?" yaptık (Soru işaretine dikkat!)
        [JsonIgnore]
        public virtual Departman? Departman { get; set; }

        // DİKKAT: "List<Gorev>?" yaptık
        [JsonIgnore]
        public virtual List<Gorev>? Gorevler { get; set; }
    }
}