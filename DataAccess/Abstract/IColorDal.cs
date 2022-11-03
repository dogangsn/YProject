using DataAccess.Generic.Dapper.Abstract;
using Entities.Dtos;
using Entities.Entities;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IColorDal : IGenericRepository<ColorModel>
    {
        List<ColorListDto> ColorList(int record, int page, string search = "");

        int ColorDelete(int id);
    }
}
