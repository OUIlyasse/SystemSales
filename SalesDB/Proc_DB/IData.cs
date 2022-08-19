using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SalesDB.Proc_DB
{
    internal interface IData<TEntity>
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        IEnumerable<TEntity> GetMaxID(Expression<Func<TEntity, bool>> p);
        IEnumerable<TEntity> GetAllData();
        IEnumerable<TEntity> GetDataBy(Expression<Func<TEntity, bool>> p);
    }
}