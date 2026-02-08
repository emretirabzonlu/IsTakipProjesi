using IsTakip.Business.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Concrete
{
    public class DepartmanManager : IDepartmanService
    {
        IDepartmanDal _departmanDal;
        public DepartmanManager(IDepartmanDal departmanDal)
        {
            _departmanDal = departmanDal;
        }
        public void Ekle(Departman d) { _departmanDal.Insert(d); }
        public void Sil(Departman d) { _departmanDal.Delete(d); }
        public void Guncelle(Departman d) { _departmanDal.Update(d); }
        public Departman GetById(int id) { return _departmanDal.Get(id); }
        public List<Departman> Listele() { return _departmanDal.List(); }
    }
}