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
    public class MainCategoryManager : IMainCategoryService
    {
        private IMainCategoryRepository _MainCategory;
        public MainCategoryManager(IMainCategoryRepository MainCategory)
        {
            _MainCategory = MainCategory;
        }
        public void Create(MainCategory T)
        {
            _MainCategory.Create(T);
        }

        public void Delete(MainCategory T)
        {
            _MainCategory.Delete(T);
        }

        public List<MainCategory> GetAll()
        {
            return _MainCategory.GetAll();
        }

        public MainCategory GetById(int id)
        {
            return _MainCategory.GetById(id);
        }

        public List<MainCategory> MainCategoryGetAll()
        {
            return _MainCategory.MainCategoryGetAll();
        }

        public void Update(MainCategory T)
        {
            _MainCategory.Update(T);
        }
        public void Clicks(string url)
        {
            _MainCategory.Clicks(url);
        }
        public List<MainCategory> GetPopulerMainCategory()
        {
            return _MainCategory.GetPopulerMainCategory();
        }
    }
}
