using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Abstract
{
    public interface ICatetgoryService
    {
        void create(Category t);
        void update(Category t);
        Category GetById(int id);
        List<Category> GetList();
        void delete(int id);
    }
}
