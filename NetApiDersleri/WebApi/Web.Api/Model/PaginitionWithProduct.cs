using System.Collections.Generic;
using Web.Entity;

namespace Web.Api.Model
{
    public class PaginitionWithProduct
    {
        public List<Product> Product { get; set; }
        public Page Page { get; set; }
    }
}
