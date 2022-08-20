using shopapp.entity;
using System.Collections.Generic;

namespace shopapp.webui.ViewModels
{
    public class CategoryViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
