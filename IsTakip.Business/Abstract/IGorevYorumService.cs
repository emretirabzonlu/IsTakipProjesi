using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Abstract
{
    public interface IGorevYorumService
    {
        void Ekle(GorevYorum gy);
        void Sil(GorevYorum gy);
        List<GorevYorum> Listele();
        List<GorevYorum> GorevYorumlariniGetir(int gorevId);
    }
}