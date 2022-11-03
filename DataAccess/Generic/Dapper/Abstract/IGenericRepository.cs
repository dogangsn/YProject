using Helpers.Interfaces;
using System.Collections.Generic;

namespace DataAccess.Generic.Dapper.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class, ITable, new()
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}
