using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Abstract
{
    public interface IProductSizeService
    {
        void Create(ProductSize T);
        void Update(ProductSize T);
        void Delete(ProductSize T);
        List<ProductSize> GetAll();
        ProductSize GetById(int id);
    }
}
