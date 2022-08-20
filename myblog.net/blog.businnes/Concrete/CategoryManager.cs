using blog.businnes.Abstract;
using blog.data.Abstract;
using blog.data.Concrete.EfCoreMysql;
using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Concrete
{
    public class CategoryManager : ICatetgoryService
    {
        private ICategoryRepository _category;
        public  CategoryManager(ICategoryRepository category)
        {
            _category = category;
        }
        public void create(Category t)
        {
            _category.create(t);
        }

        public void delete(int id)
        {
            _category.delete(id); 
        }

        public Category GetById(int id)
        {
            return _category.GetById(id);
        }

        public List<Category> GetList()
        {
            return _category.GetList();
        }

        public void update(Category t)
        {
            _category.update(t);
        }

    }
}
