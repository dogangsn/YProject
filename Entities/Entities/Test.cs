using Dapper.Contrib.Extensions;
using Helpers.Interfaces;

namespace Entities.Entities
{
    [Table("Test")]
    public class Test : ITable
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
