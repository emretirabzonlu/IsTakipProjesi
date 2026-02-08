using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IsTakip.Business.Abstract;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.Business.Concrete
{
    // Bu sınıf IRepository şablonuna uymak zorundadır (: IRepository<T>)
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        // VERİTABANI BAĞLANTISI (Context)
        // Her işlemde 'using' kullanarak belleği şişirmesini engelliyoruz.
        IsTakipContext c = new IsTakipContext();
        DbSet<T> _object;

        // Yapıcı Metot (Constructor): Sınıf çalıştığı an T neyse (Personel, Görev) onu ayarlar.
        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
