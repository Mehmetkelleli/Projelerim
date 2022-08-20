using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _Product;

        public string ErrorMesage { get; set; }

        public ProductManager(IProductRepository Product)
        {
            _Product = Product;
        }
        public bool Create(Product P)
        {
            if (Validation(P))
            {
                _Product.Create(P);
                return true;
            }
            return false;

        }

        public void Delete(Product P)
        {
            _Product.Delete(P);
        }

        public List<Product> GetByCategory(string name,int page,int pagesize)
        {
            return _Product.GetByCategory(name,page,pagesize);
        }

        public Product GetById(int i)
        {
            return _Product.GetById(i);
        }

        public List<Product> GetList()
        {
            return _Product.GetList();
        }

        public Product GetproductDetails(string name)
        {
            return _Product.GetProductDetails(name);
        }

        public void Update(Product P)
        {
            _Product.Update(P);
        }
        public int GetByCategoryCount(string Category,string search)
        {
            return _Product.GetByCategoryCount(Category,search);
        }
        public List<Product> GetHomeProducts()
        {
            return _Product.GetHomeProduct();
        }

        public List<Product> GetSearchProducts(string search,int page,int pagesize)
        {
            return _Product.GetSearchProducts(search,page,pagesize);
        }
        public Product GetByIdWidthCategories(int id)
        {
            return _Product.GetByIdWidthCategories(id);
        }

        public bool Update(Product p, int[] categoryId)
        {
            if (Validation(p))
            {
                if (categoryId.Length == 0)
                {
                    ErrorMesage += "Ürürn için en az bir kategori seçilmek zorundadır";
                    return false;
                }
                _Product.Update(p, categoryId);
                return true;
            }
            return false;
            
        }

        public bool Validation(Product Entity)
        {
            
            if (string.IsNullOrEmpty(Entity.Name))
            {
                ErrorMesage += "Name alanı Boş";
                return false;
            }
            if (Entity.Price <= 0)
            {
                ErrorMesage += "Fiyat sıfır veya negatif olamaz";
                return false;
            }
            return true;
        }
    }
}
