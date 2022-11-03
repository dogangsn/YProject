using DataAccess.Generic.Dapper.Abstract;
using Entities.Entities;

namespace DataAccess.Abstract
{
    public interface IUserDal : IGenericRepository<UserModel>
    {
        public UserModel CheckLogin(string userName, string password);
    }
}
