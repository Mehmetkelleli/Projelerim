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
    public class ProductSizeManager : IProductSizeService
    {
        private IProductSizeRepository _ProductSize;
            public ProductSizeManager(IProductSizeRepository ProductSize)
        {
            _ProductSize = ProductSize;
        }
        public void Create(ProductSize T)
        {
            _ProductSize.Create(T);
        }

        public void Delete(ProductSize T)
        {
            _ProductSize.Delete(T);
        }

        public List<ProductSize> GetAll()
        {
            return _ProductSize.GetAll();
        }

        public ProductSize GetById(int id)
        {
            return _ProductSize.GetById(id);
        }

        public void Update(ProductSize T)
        {
            _ProductSize.Update(T);
        }
    }
}
