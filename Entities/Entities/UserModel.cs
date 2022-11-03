using Dapper.Contrib.Extensions;
using Helpers.Interfaces;

namespace Entities.Entities
{
    [Table("Users")]
    public class UserModel : ITable
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Token { get; set; }
    }

}
