using Dapper.Contrib.Extensions;
using Helpers.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Entities.Entities
{
    [Table("Products")]
    public class ProductModel : ITable
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int ColorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price1 { get; set; }
        public decimal Price2 { get; set; }
        public string Barcode { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public bool ShowHomePage { get; set; }
        public byte OrderNumber { get; set; }

        [Write(false)]
        [Computed]
        public List<ProductImageModel> ProductImages { get; set; }
        [Write(false)]
        [Computed]
        public IList<IFormFile> IProductImages { get; set; }
    }
}
