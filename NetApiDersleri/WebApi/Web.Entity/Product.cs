using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameUrl { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public Double Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
