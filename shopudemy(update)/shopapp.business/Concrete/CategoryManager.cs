using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _Category;
        public CategoryManager(ICategoryRepository Category)
        {
            _Category = Category;
        }


        public bool Create(Category T)
        {
            if (Validation(T))
            {
                _Category.Create(T);
                return true;
            }
            return false;
        }

        public void Delete(Category T)
        {
            _Category.Delete(T);
        }

        public void DeleteFromCategory(int CategoryId, int ProductId)
        {
            _Category.DeleteFromCategory(CategoryId, ProductId);
        }

        public Category GetById(int i)
        {
            return _Category.GetById(i);
        }

        public Category GetByIdWidthProducts(int id)
        {
            return _Category.GetByIdWidthProducts(id);
        }

        public List<Category> GetList()
        {
            return _Category.GetList();
        }

        public bool Update(Category T)
        {
            if (Validation(T)){
                _Category.Update(T);
                return true;
            }
            return false;
        }
        public string ErrorMesage { get; set; }

        public bool Validation(Category Entity)
        {
            var process = true;
            if (string.IsNullOrEmpty(Entity.Name))
            {
                ErrorMesage += "Name is Not null \n";
                process = false;
            }
            if (!string.IsNullOrEmpty(Entity.Name))
            {
                if (Entity.Name.Length > 5 && Entity.Name.Length < 30)
                {
                    
                    process = true;
                }
                else
                {
                    ErrorMesage += "Name is 5 ile 30 arasında olmak zorundadır";
                    process = false;
                }

            }

            if (string.IsNullOrEmpty(Entity.Url))
            {
                ErrorMesage += "Url is Not null \n";
                process = false;
            }
            return process;
        }

    }
}
