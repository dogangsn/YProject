using Dapper;
using DataAccess.Abstract;
using DataAccess.Generic.Context;
using DataAccess.Generic.Dapper.Concrete;
using Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class ProductImageDal : GenericRepository<ProductImageModel>, IProductImageDal
    {
        public List<ProductImageModel> ProductImages(int productId)
        {
            using var context = Db.GetConnection();
            string sql = "SELECT * FROM ProductImages WITH(NOLOCK) WHERE ProductId = @ProductId";
            var parameters = new { ProductId = productId };
            var data = context.Query<ProductImageModel>(sql, parameters).ToList();
            return data;
        }

        public int ProductImagesDelete(int id)
        {
            using var context = Db.GetConnection();
            string sql = "DELETE ProductImages WHERE ProductId=@ProductId";
            var parameters = new { ProductId = id };
            var data = context.Execute(sql, parameters);
            return data;
        }
    }
}
