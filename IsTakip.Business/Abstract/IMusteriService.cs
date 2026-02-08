using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Abstract
{
    public interface IMusteriService
    {
        void MusteriEkle(Musteri m);
        void MusteriSil(Musteri m);
        void MusteriGuncelle(Musteri m);
        List<Musteri> Listele();
        Musteri GetById(int id);
    }
}