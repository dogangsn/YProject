using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class ProductsDto
    {
        public List<CategoryModel> Categories { get; set; }
        public List<ProductCardDto> Products { get; set; }
        public List<ColorModel> Colors { get; set; }


    }
}
