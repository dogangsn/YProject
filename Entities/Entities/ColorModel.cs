using Dapper.Contrib.Extensions;
using Helpers.Interfaces;
namespace Entities.Entities
{
    [Table("Colors")]
    public class ColorModel : ITable
    {
        [Key]
        public int ColorId { get; set; }
        public string Name { get; set; }
    }
}
