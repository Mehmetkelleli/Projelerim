using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.entity
{
   public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public List<ProductCategory> ProductCategory { get; set; }
        public int MainCategoryId { get; set; }
        public MainCategory MainCategory { get; set; }
    }
}
