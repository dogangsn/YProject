using Dapper;
using DataAccess.Abstract;
using DataAccess.Generic.Context;
using DataAccess.Generic.Dapper.Concrete;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class TestDal : GenericRepository<Test>, ITestDal
    {
        public List<Test> BoatList()
        {
            using var context = Db.GetConnection();
            string sql = "SELECT * FROM Test"; 
            var data = context.Query<Test>(sql).ToList();
            return data;
        }
        //public List<BoatListDto> BoatList(int record, int page, string search = "")
        //{
        //    using var context = Db.GetConnection();
        //    string sql = "EXEC BoatList @Records,@Page,@Search";
        //    var parameters = new { Records = record, Page = page, Search = search };
        //    var data = context.Query<BoatListDto>(sql, parameters).ToList();
        //    return data;
        //}
        //public int BoatDelete(int id)
        //{
        //    using var context = Db.GetConnection();
        //    string sql = "UPDATE Boats SET IsDeleted=1 WHERE BoatId=@BoatId";
        //    var parameters = new { BoatId = id };
        //    var data = context.Execute(sql, parameters);
        //    return data;
        //}
    }
}
