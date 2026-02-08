using System.Collections.Generic;
using System.Text.Json.Serialization; // <--- BU LAZIM (JsonIgnore için)

namespace IsTakip.Entities
{
    public class Departman : BaseEntity
    {
        public string Ad { get; set; }

        // ESKİ HALİ: public virtual List<Personel> Personeller { get; set; }

        // YENİ HALİ (Soru işareti ve JsonIgnore ekledik):
        [JsonIgnore]
        public virtual List<Personel>? Personeller { get; set; }
    }
}