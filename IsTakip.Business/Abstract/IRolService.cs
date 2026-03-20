using IsTakip.Entities;
using System.Collections.Generic;

namespace IsTakip.Business.Abstract
{
    public interface IRolService
    {
        List<Rol> Listele();
        Rol GetById(int id);
    }
}