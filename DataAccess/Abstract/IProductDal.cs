using DataAccess.Generic.Dapper.Abstract;
using Entities.Dtos;
using Entities.Entities;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductDal : IGenericRepository<ProductModel>
    {
        List<ProductListDto> ProductList(int record, int page, string search = "");
        ProductModel ProductGet(int id);
        int ProductDelete(int id);
        List<CategoryListForProductDto> CategoryListForProduct();
        List<ProductCardDto> ProductListForHomePage();
        List<ProductCardDto> ProductCardListAll();
        List<ProductCardDto> ProductCardListWithCategoryId(int categoryId);
    }
}
