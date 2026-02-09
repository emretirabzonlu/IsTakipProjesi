using System.Collections.Generic;

namespace IsTakip.Entities
{
    public class GorevTipi : BaseEntity
    {
        public string Ad { get; set; }
        public string Simge { get; set; }

        public virtual ICollection<Gorev> Gorevler { get; set; }
    }
}