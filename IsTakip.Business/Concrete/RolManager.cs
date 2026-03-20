using IsTakip.Business.Abstract;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Concrete
{
    public class RolManager : IRolService
    {
        IRolDal _rolDal;

        public RolManager(IRolDal rolDal)
        {
            _rolDal = rolDal;
        }

        public List<Rol> Listele()
        {
            return _rolDal.List();
        }

        public Rol GetById(int id)
        {
            return _rolDal.Get(id);
        }
    }
}