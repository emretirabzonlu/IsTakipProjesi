using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public bool SilindiMi { get; set; } = false;

    }
}
