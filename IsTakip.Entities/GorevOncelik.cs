using System.Collections.Generic;

namespace IsTakip.Entities
{
    public class GorevOncelik : BaseEntity
    {
        public string Ad { get; set; }
        public int Derece { get; set; } // 1, 2, 3
        public string Renk { get; set; }

        public virtual ICollection<Gorev> Gorevler { get; set; }
    }
}