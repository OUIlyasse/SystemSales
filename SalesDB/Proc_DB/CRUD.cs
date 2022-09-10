using SalesDB.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using static myTools.Tools;

namespace SalesDB.Proc_DB
{
    public class CRUD<TEntity> : IData<TEntity> where TEntity : class
    {
        #region Variables
        private SystemSalesEntities db = new SystemSalesEntities();
        #endregion Variables

        #region Codes
        public bool Add(TEntity entity)
        {
            try
            {
                db.Set<TEntity>().Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ILmsgBox(ex.Message);
                return false;
            }
        }
        public bool Delete(TEntity entity)
        {
            try
            {
                db.Set<TEntity>().Remove(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ILmsgBox(ex.Message);
                return false;
            }
        }

        public bool Delete(object valeur)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAllData()
        {
            try
            {
                return db.Set<TEntity>().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<TEntity> GetDataBy(Expression<Func<TEntity, bool>> p)
        {
            try
            {
                return db.Set<TEntity>().Where(p);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<TEntity> GetMaxID(Expression<Func<TEntity, bool>> p)
        {
            try
            {
                return db.Set<TEntity>().Where(p);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool Update(TEntity entity)
        {
            try
            {
                db.Set<TEntity>().AddOrUpdate(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ILmsgBox(ex.Message);
                return false;
            }
        }
        #endregion Codes
    }
}