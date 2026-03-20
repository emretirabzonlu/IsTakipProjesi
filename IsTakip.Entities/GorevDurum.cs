using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IsTakip.Entities
{
    public class GorevDurum : BaseEntity
    {
        public string Ad { get; set; } // "Yeni", "Devam Ediyor", "Tamamlandı", "İptal"

        [JsonIgnore]
        public virtual List<Gorev>? Gorevler { get; set; }
    }
}