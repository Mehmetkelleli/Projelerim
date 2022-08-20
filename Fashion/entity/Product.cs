using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public bool IsHome { get; set; }
        public string ImgUrl { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int Click { get; set; }
        public List<ProductSize> ProductSize { get; set; }
        public bool Active { get; set; }
        public List<ProductCategory> ProductCategory { get; set; }

    }
}
