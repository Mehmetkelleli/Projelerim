using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.entity
{
    public class MainCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int clicsk { get; set; }
        public List<Category> Categories { get; set; }
    }
}
