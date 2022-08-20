using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Abstract
{
    public interface ICategoryService
    {
        void Create(Category T);
        void Update(Category T);
        void Delete(Category T);
        List<Category> GetAll();
        Category GetById(int id);
        Category GetCategoryProducts(int id);
        void CategoryProductDelete(int ProductId, int CategoryId);
    }
}
