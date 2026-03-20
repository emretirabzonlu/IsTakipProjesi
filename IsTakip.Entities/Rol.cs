using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IsTakip.Entities
{
    public class Rol : BaseEntity
    {
        public string Ad { get; set; } // "Admin", "Kullanıcı", "Yönetici"

        [JsonIgnore]
        public virtual List<Personel>? Personeller { get; set; }
    }
}