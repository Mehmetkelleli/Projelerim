using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        List<Category> GetPopulerCategories();
        Category GetByIdWidthProducts(int CategoryId);
        void DeleteFromCategory(int CategoryId,int ProductId);
    }
}
