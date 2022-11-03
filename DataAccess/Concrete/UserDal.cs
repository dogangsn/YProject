using Dapper;
using DataAccess.Abstract;
using DataAccess.Generic.Context;
using DataAccess.Generic.Dapper.Concrete;
using Entities.Entities;
using System.Linq;

namespace DataAccess.Concrete
{

    public class UserDal : GenericRepository<UserModel>, IUserDal
    {
        public UserModel CheckLogin(string userName, string password)
        {
            using var context = Db.GetConnection();
            string sql = "SELECT * FROM Users WITH(NOLOCK) WHERE UserName = @UserName AND Password = @Password";
            var parameters = new { UserName = userName, Password = password };
            var data = context.Query<UserModel>(sql, parameters).FirstOrDefault();
            return data;
        }
    }
}
