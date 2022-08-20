using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.entity
{
    public class ProductSize
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public int Total { get; set; }
        public int ProductId{ get; set; }
        public Product Product { get; set; }
    }
}
