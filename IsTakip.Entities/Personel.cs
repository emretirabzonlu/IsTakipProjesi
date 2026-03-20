using System.Collections.Generic;
using System.Text.Json.Serialization;

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
        [JsonIgnore]
        public virtual Departman? Departman { get; set; }

        // YENİ: Rol
        public int RolId { get; set; }
        [JsonIgnore]
        public virtual Rol? Rol { get; set; }

        [JsonIgnore]
        public virtual List<Gorev>? Gorevler { get; set; }
    }
}