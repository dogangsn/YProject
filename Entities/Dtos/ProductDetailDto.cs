using Entities.Entities;
using System.Collections.Generic;

namespace Entities.Dtos
{
    public class ProductDetailDto
    {
        public ProductModel ProductModel { get; set; }
        public List<ProductImageModel> ProductImagesModel { get; set; }
        public CategoryModel CategoryModel { get; set; }
        public ColorModel ColorModel { get; set; }
        public List<ProductCardDto> RelatedProducts { get; set; }
    }
}
