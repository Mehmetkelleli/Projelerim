using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muhasebe.entity.EntityClass
{
    public class Process
    {
        public int Id { get; set; }
        public string Acıklama {get;set;}
        public int Kayıp { get; set; }
        public int Kazanc { get; set; }
        public int ProcessCategoryId { get; set; }
        public ProcessCategory ProcessCategory { get; set; }

    }
}
