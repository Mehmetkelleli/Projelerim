using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muhasebe.entity.EntityClass
{
    public class ProcessCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Process> Process { get; set; }

    }
}
