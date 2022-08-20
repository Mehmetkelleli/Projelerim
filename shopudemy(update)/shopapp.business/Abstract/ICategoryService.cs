using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Abstract
{
    public interface ICategoryService:IValidation<Category>
    {
        void DeleteFromCategory(int CategoryId, int ProductId);
        Category GetByIdWidthProducts(int id);
        Category GetById(int i);
        List<Category> GetList();
        bool Update(Category T);
        bool Create(Category T);
        void Delete(Category T);
    }
}
