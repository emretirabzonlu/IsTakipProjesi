using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities
{
    public class Proje : BaseEntity
    {
        public string ProjeAdi { get; set; }
        public string Aciklama { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; } // "?" koyduk çünkü proje henüz bitmemiş olabilir (Null olabilir)
        public string Durum { get; set; } // "Devam Ediyor", "Tamamlandı", "İptal"

        // Foreign Key: Bir proje mutlaka bir müşteriye aittir
        public int MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }

        // Bir projede birden fazla görev olabilir (Bunu ileride Görev tablosuna da bağlayacağız)
        // Şimdilik burası böyle kalsın.
    }
}
