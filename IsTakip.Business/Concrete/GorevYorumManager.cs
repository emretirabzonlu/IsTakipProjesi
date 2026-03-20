using IsTakip.Business.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Concrete
{
    public class GorevYorumManager : IGorevYorumService
    {
        IGorevYorumDal _gorevYorumDal;

        public GorevYorumManager(IGorevYorumDal gorevYorumDal)
        {
            _gorevYorumDal = gorevYorumDal;
        }

        public void Ekle(GorevYorum gy)
        {
            _gorevYorumDal.Insert(gy);
        }

        public void Sil(GorevYorum gy)
        {
            _gorevYorumDal.Delete(gy);
        }

        public List<GorevYorum> Listele()
        {
            return _gorevYorumDal.List();
        }

        public List<GorevYorum> GorevYorumlariniGetir(int gorevId)
        {
            return _gorevYorumDal.List(x => x.GorevId == gorevId);
        }
    }
}