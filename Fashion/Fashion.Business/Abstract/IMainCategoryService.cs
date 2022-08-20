using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Abstract
{
    public interface IMainCategoryService
    {
        void Create(MainCategory T);
        void Update(MainCategory T);
        void Delete(MainCategory T);
        List<MainCategory> GetAll();
        MainCategory GetById(int id);
        List<MainCategory> MainCategoryGetAll();
        void Clicks(string url);
        List<MainCategory> GetPopulerMainCategory();
    }
}
