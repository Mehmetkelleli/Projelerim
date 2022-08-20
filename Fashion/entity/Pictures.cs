using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.entity
{
    public class Pictures
    {
        public int Id { get; set; }
        public string url { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
