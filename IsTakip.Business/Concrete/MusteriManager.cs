using IsTakip.Business.Abstract;
using IsTakip.DataAccess.Abstract; // <--- KRİTİK EKSİK
using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteriDal;

        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public void MusteriEkle(Musteri m)
        {
            _musteriDal.Insert(m);
        }

        public void MusteriGuncelle(Musteri m)
        {
            _musteriDal.Update(m);
        }

        public void MusteriSil(Musteri m)
        {
            _musteriDal.Delete(m);
        }

        public List<Musteri> Listele()
        {
            return _musteriDal.List();
        }

        public Musteri GetById(int id)
        {
            return _musteriDal.Get(id);
        }
    }
}