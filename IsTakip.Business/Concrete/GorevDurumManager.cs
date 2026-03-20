using IsTakip.Business.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Concrete
{
    public class GorevDurumManager : IGorevDurumService
    {
        IGorevDurumDal _gorevDurumDal;

        public GorevDurumManager(IGorevDurumDal gorevDurumDal)
        {
            _gorevDurumDal = gorevDurumDal;
        }

        public List<GorevDurum> Listele()
        {
            return _gorevDurumDal.List();
        }

        public GorevDurum GetById(int id)
        {
            return _gorevDurumDal.Get(id);
        }
    }
}