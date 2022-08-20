using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core.DbModels
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }

        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        public int ProductBrandId { get; set; }
        public ProductBrand ProductBrand { get; set; }

    }
}
