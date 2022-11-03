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
    public class CategoryDal : GenericRepository<CategoryModel>, ICategoryDal
    {
        public int CategoryDelete(int id)
        {
            using var context = Db.GetConnection();
            string sql = "DELETE Categories WHERE CategoryId=@CategoryId";
            var parameters = new { CategoryId = id };
            var data = context.Execute(sql, parameters);
            return data;
        }

        public CategoryModel CategoryGet(int id)
        {
            using var context = Db.GetConnection();
            string sql = "EXEC CategoryGet @Id";
            var parameters = new { Id = id };
            var data = context.Query<CategoryModel>(sql, parameters).FirstOrDefault();
            return data;
        }

        public List<CategoryListDto> CategoryList(int record, int page, string search = "")
        {
            using var context = Db.GetConnection();
            string sql = "EXEC CategoryList @Records,@Page,@Search";
            var parameters = new { Records = record, Page = page, Search = search };
            var data = context.Query<CategoryListDto>(sql, parameters).ToList();
            return data;
        }
    }
}
