using IsTakip.Business.Abstract;
using IsTakip.DataAccess.Abstract; // <--- KRİTİK EKSİK BUYDU
using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Concrete
{
    public class GorevManager : IGorevService
    {
        IGorevDal _gorevDal;

        public GorevManager(IGorevDal gorevDal)
        {
            _gorevDal = gorevDal;
        }

        public void GorevEkle(Gorev g)
        {
            _gorevDal.Insert(g);
        }

        public void GorevGuncelle(Gorev g)
        {
            _gorevDal.Update(g);
        }

        public void GorevSil(Gorev g)
        {
            _gorevDal.Delete(g);
        }

        public List<Gorev> Listele()
        {
            return _gorevDal.List();
        }

        public Gorev GetById(int id)
        {
            return _gorevDal.Get(id);
        }
    }
}