using System.Collections.Generic;

namespace IsTakip.Entities
{
    public class GorevDurum : BaseEntity
    {
        public string Ad { get; set; }
        public int SiraNo { get; set; }

        public virtual ICollection<Gorev> Gorevler { get; set; }
    }
}