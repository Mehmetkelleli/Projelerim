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
    public class CategoryManager:ICategoryService
    {
        private ICategoryRepository _Category;
        public CategoryManager(ICategoryRepository Category)
        {
            _Category = Category;
        }
        public void Create(Category T)
        {
            _Category.Create(T);
        }

        public void Delete(Category T)
        {
            _Category.Delete(T);
        }

        public List<Category> GetAll()
        {
            return _Category.GetAll();
        }

        public Category GetById(int id)
        {
            return _Category.GetById(id);
        }

        public void Update(Category T)
        {
            _Category.Update(T);
        }
        public Category GetCategoryProducts(int id)
        {
           return _Category.GetCategoryProducts(id);
        }

        public void CategoryProductDelete(int ProductId, int CategoryId)
        {
            _Category.CategoryProductDelete(ProductId, CategoryId);
        }
    }
}
