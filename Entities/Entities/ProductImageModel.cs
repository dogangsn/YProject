using Dapper.Contrib.Extensions;
using Helpers.Interfaces;

namespace Entities.Entities
{
    [Table("ProductImages")]
    public class ProductImageModel : ITable
    {
        [Key]
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public byte OrderNumber { get; set; }
    }
}
