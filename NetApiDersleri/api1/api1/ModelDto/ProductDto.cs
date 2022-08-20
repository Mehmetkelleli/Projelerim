using Api.Core.DbModels;

namespace api1.ModelDto
{
    public class ProductDto
    {
        public int Id { get; set; }
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
