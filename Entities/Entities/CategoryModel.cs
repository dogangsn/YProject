using Dapper.Contrib.Extensions;
using Helpers.Interfaces;

namespace Entities.Entities
{
    [Table("Categories")]
    public class CategoryModel : ITable
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public byte OrderNumber { get; set; }
    }
}
