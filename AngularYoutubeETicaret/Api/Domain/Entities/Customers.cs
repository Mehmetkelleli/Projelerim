using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customers:BaseEntity
    {
        public ICollection<Orders> Orders { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
