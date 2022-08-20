using Fashion.Business.Abstract;
using Fashion.Data.Abstract;
using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Concrete
{

    public class ColorManager : IColorService
    {
        private IColorRepository _Color;
        public ColorManager(IColorRepository Color)
        {
            _Color = Color;
        }
        public void Create(Color T)
        {
            _Color.Create(T);
        }

        public void Delete(Color T)
        {
            _Color.Delete(T);
        }

        public List<Color> GetAll()
        {
           return _Color.GetAll();
        }

        public Color GetById(int id)
        {
            return _Color.GetById(id);
        }

        public void Update(Color T)
        {
            _Color.Update(T);
        }
    }
}
