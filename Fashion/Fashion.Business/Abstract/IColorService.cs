using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Abstract
{
    public interface IColorService
    {
        void Create(Color T);
        void Update(Color T);
        void Delete(Color T);
        List<Color> GetAll();
        Color GetById(int id);
    }
}
