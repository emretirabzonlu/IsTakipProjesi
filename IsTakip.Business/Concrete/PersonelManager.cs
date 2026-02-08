using IsTakip.Business.Abstract;
using IsTakip.DataAccess.Abstract; // <--- KRİTİK EKSİK
using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public void PersonelEkle(Personel p)
        {
            _personelDal.Insert(p);
        }

        public void PersonelGuncelle(Personel p)
        {
            _personelDal.Update(p);
        }

        public void PersonelSil(Personel p)
        {
            _personelDal.Delete(p);
        }

        public List<Personel> Listele()
        {
            return _personelDal.List();
        }

        public Personel GetById(int id)
        {
            return _personelDal.Get(id);
        }
    }
}