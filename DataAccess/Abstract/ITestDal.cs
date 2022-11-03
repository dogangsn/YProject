using DataAccess.Generic.Dapper.Abstract;
using Entities.Entities;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ITestDal : IGenericRepository<Test>
    {
        List<Test> BoatList();
        //List<Test> BoatList(int record, int page, string search = "");
        //int BoatDelete(int id);
    }
}
