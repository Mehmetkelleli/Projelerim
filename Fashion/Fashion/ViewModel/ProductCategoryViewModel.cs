using Fashion.entity;
using Fashion.Models;
using System.Collections.Generic;

namespace Fashion.ViewModel
{
    public class ProductCategoryViewModel
    {
        public List<MainCategory> MainCategories { get; set; }
        public List<Product> Product { get; set; }
        public List<Category> Categories { get; set; }
        public Product product { get; set; }
        public List<Product> PopulerProducts { get; set; }
        public Category Category { get; set; }
        public Page Page { get; set; }
    }
}
