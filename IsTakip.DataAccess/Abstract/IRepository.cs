using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Business.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> List(); // Tüm kayıtları listele

        void Insert(T p); // Yeni kayıt ekle

        T Get(int id); // Id'ye göre tek bir kayıt getir

        void Update(T p); // Kaydı güncelle

        void Delete(T p); // Kaydı sil

        // (Opsiyonel ama çok havalı) Şartlı listeleme: Örn: "Sadece İstanbul'da yaşayanları getir"
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
