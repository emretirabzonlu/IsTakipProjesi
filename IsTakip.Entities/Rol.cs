using System.Collections.Generic;

namespace IsTakip.Entities
{
    public class Rol : BaseEntity
    {
        public string Ad { get; set; }
        public string Kod { get; set; } // admin, user vs.

        public virtual ICollection<Personel> Personeller { get; set; }
    }
}