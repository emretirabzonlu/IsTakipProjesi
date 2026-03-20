using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Abstract
{
    public interface IGorevDurumService
    {
        List<GorevDurum> Listele();
        GorevDurum GetById(int id);
    }
}