using DataAccess.Generic.Dapper.Abstract;
using Entities.Dtos;
using Entities.Entities;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IGenericRepository<CategoryModel>
    {
        List<CategoryListDto> CategoryList(int record, int page, string search = "");
        CategoryModel CategoryGet(int id);
        int CategoryDelete(int id);
    }
}
