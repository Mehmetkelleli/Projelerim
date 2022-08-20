using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.entity
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ColorCode { get; set; }
        public List<Product> Product { get; set; }
    }
}
