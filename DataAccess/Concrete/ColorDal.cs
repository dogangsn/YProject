using Dapper;
using DataAccess.Abstract;
using DataAccess.Generic.Context;
using DataAccess.Generic.Dapper.Concrete;
using Entities.Dtos;
using Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class ColorDal : GenericRepository<ColorModel>, IColorDal
    {
        public int ColorDelete(int id)
        {
            using var context = Db.GetConnection();
            string sql = "DELETE Colors WHERE ColorId=@ColorId";
            var parameters = new { ColorId = id};
            var data = context.Execute(sql, parameters);
            return data;
        }

        public List<ColorListDto> ColorList(int record, int page, string search = "")
        {
            using var context = Db.GetConnection();
            string sql = "EXEC ColorList @Records,@Page,@Search";
            var parameters = new { Records = record, Page = page, Search = search };
            var data = context.Query<ColorListDto>(sql, parameters).ToList();
            return data;
        }
       
    }
}
