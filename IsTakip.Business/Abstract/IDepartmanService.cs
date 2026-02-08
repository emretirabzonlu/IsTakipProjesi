using IsTakip.Entities;
using System.Collections.Generic;
namespace IsTakip.Business.Abstract
{
    public interface IDepartmanService
    {
        void Ekle(Departman d);
        void Sil(Departman d);
        void Guncelle(Departman d);
        List<Departman> Listele();
        Departman GetById(int id);
    }
}