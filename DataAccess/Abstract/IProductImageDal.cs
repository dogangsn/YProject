using DataAccess.Generic.Dapper.Abstract;
using Entities.Entities;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductImageDal : IGenericRepository<ProductImageModel>
    {
        int ProductImagesDelete(int id);

        List<ProductImageModel> ProductImages(int productId);
    }
}
