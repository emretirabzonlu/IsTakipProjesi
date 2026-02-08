using IsTakip.Business.Abstract;
using IsTakip.Business.Concrete;
using IsTakip.DataAccess.Abstract;
using IsTakip.Entities;

// HATA BURADAYDI: Business değil DataAccess olmalı!
namespace IsTakip.DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : GenericRepository<Personel>, IPersonelDal
    {
    }
}