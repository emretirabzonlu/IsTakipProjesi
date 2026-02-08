using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities
{
    public class Musteri : BaseEntity
    {
        public string Ad { get; set; }     // Firma adı veya şahıs adı
        public string Soyad { get; set; }  // Şahıs ise soyadı (Opsiyonel)
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string VergiNo { get; set; } // Kurumsal müşteriler için

        // Bir müşterinin birden fazla projesi olabilir
        public virtual ICollection<Proje> Projeler { get; set; }
    }
}
