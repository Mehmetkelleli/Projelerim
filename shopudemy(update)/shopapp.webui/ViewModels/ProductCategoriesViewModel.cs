using shopapp.entity;
using System.Collections.Generic;

namespace shopapp.webui.ViewModels
{
    public class ProductCategoriesViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
