using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Data.Abstract
{
    public interface IMainCategoryRepository:IGenericRepository<MainCategory>
    {
        List<MainCategory> MainCategoryGetAll();
        void Clicks(string url);
        List<MainCategory> GetPopulerMainCategory();
    }
}
