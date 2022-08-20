using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string  Description { get; set; }
        public int Stock { get; set; }
        public bool Price { get; set; }
        public Category Category { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
