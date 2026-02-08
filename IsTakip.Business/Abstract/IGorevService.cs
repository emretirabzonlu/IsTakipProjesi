using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Abstract
{
    public interface IGorevService
    {
        void GorevEkle(Gorev g);
        void GorevSil(Gorev g);
        void GorevGuncelle(Gorev g);
        List<Gorev> Listele();
        Gorev GetById(int id);
    }
}