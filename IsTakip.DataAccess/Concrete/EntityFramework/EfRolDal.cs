using IsTakip.Business.Concrete;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities;

namespace IsTakip.DataAccess.Concrete.EntityFramework
{
    public class EfRolDal : GenericRepository<Rol>, IRolDal
    {
    }
}