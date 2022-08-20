using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Data.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Category GetCategoryProducts(int id);
        void CategoryProductDelete(int ProductId, int CategoryId);
    }
}
