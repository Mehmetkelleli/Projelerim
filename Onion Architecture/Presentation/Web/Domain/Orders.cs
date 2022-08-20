using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Orders:BaseEntity
    {
        public string Adress { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
