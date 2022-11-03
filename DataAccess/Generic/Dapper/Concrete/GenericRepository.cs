using Dapper.Contrib.Extensions;
using DataAccess.Generic.Context;
using DataAccess.Generic.Dapper.Abstract;
using Helpers.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Generic.Dapper.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
       where TEntity : class, ITable, new()

    {
        public List<TEntity> GetAll()
        {
            using var context = Db.GetConnection();
            return context.GetAll<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            using var context = Db.GetConnection();
            return context.Get<TEntity>(id);
        }

        public TEntity Update(TEntity entity)
        {
            using var context = Db.GetConnection();
            context.Update(entity);
            return entity;
        }
        public bool Delete(TEntity entity)
        {
            using var context = Db.GetConnection();
            return context.Delete(entity);
        }

        public TEntity Add(TEntity entity)
        {
            using var context = Db.GetConnection();
            context.Insert(entity);
            return entity;
        }

    }

}
