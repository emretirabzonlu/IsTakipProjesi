using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Abstract
{
    public interface IPersonelService
    {
        void PersonelEkle(Personel p);
        void PersonelSil(Personel p);
        void PersonelGuncelle(Personel p);
        List<Personel> Listele();
        Personel GetById(int id);
    }
}