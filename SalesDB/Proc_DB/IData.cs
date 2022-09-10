﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SalesDB.Proc_DB
{
    internal interface IData<T>
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Delete(Object valeur);
        IEnumerable<T> GetAllData();
        IEnumerable<T> GetDataBy(Expression<Func<T, bool>> p);
        IEnumerable<T> GetMaxID(Expression<Func<T, bool>> p);
        bool Update(T entity);
    }
}