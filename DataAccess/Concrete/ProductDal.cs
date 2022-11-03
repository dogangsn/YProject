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
    public class ProductDal : GenericRepository<ProductModel>, IProductDal
    {
        public List<CategoryListForProductDto> CategoryListForProduct()
        {
            using var context = Db.GetConnection();
            string sql = "SELECT CategoryId,Name FROM Categories WITH(NOLOCK) ORDER BY OrderNumber";
            var data = context.Query<CategoryListForProductDto>(sql).ToList();
            return data;
        }

        public int ProductDelete(int id)
        {
            using var context = Db.GetConnection();
            string sql = "DELETE Products WHERE ProductId=@ProductId";
            var parameters = new { ProductId = id };
            var data = context.Execute(sql, parameters);
            return data;
        }

        public ProductModel ProductGet(int id)
        {
            using var context = Db.GetConnection();
            string sql = "EXEC ProductGet @Id";
            var parameters = new { Id = id };
            var data = context.Query<ProductModel>(sql, parameters).FirstOrDefault();
            return data;
        }

        public List<ProductListDto> ProductList(int record, int page, string search = "")
        {
            using var context = Db.GetConnection();
            string sql = "EXEC ProductList @Records,@Page,@Search";
            var parameters = new { Records = record, Page = page, Search = search };
            var data = context.Query<ProductListDto>(sql, parameters).ToList();
            return data;
        }

        public List<ProductCardDto> ProductListForHomePage()
        {
            using var context = Db.GetConnection();
            string sql = @"SELECT
                            ProductId,
                            Image = (SELECT TOP(1)ImagePath FROM ProductImages WITH(NOLOCK) WHERE ProductImages.ProductId = Products.ProductId AND ProductImages.OrderNumber = 1),
                            Name,
                            Price1,
                            Price2
                            FROM Products  WITH(NOLOCK) WHERE IsActive = 1 AND Stock> 0 AND ShowHomePage=1
                            ORDER BY OrderNumber ASC,ProductId DESC";
            var data = context.Query<ProductCardDto>(sql).ToList();
            return data;
        }
        public List<ProductCardDto> ProductCardListAll()
        {
            using var context = Db.GetConnection();
            string sql = @"SELECT
                            ProductId,
                            Image = (SELECT TOP(1)ImagePath FROM ProductImages WITH(NOLOCK) WHERE ProductImages.ProductId = Products.ProductId AND ProductImages.OrderNumber = 1),
                            Name,
                            Price1,
                            Price2
                            FROM Products  WITH(NOLOCK) WHERE IsActive = 1 AND Stock>0
                            ORDER BY ProductId DESC";
            var data = context.Query<ProductCardDto>(sql).ToList();
            return data;
        }

        public List<ProductCardDto> ProductCardListWithCategoryId(int categoryId)
        {
            using var context = Db.GetConnection();
            string sql = @"SELECT 
                            ProductId,
                            Image = (SELECT TOP(1)ImagePath FROM ProductImages WITH(NOLOCK) WHERE ProductImages.ProductId = Products.ProductId AND ProductImages.OrderNumber = 1),
                            Name,
                            Price1,
                            Price2
                            FROM Products WITH(NOLOCK) WHERE IsActive = 1 AND Stock> 0 AND CategoryId = @CategoryId
                            ORDER BY ProductId DESC";
            var parameters = new { CategoryId = categoryId };
            var data = context.Query<ProductCardDto>(sql, parameters).ToList();
            return data;
        }
    }
}
