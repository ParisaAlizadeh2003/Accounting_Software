using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_DataLayer.Services
{
    public class GenericRepositoty<TEntity> where TEntity : class
    {
        private Accounting_DBEntities _dbEntities;
        private DbSet<TEntity> _dbSet;

        public GenericRepositoty(Accounting_DBEntities db)
        {
            _dbEntities = db;
            _dbSet = _dbEntities.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }
        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }
        public virtual bool Insert(TEntity entity)
        {
            _dbSet.Add(entity);
            return true;
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbEntities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_dbEntities.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual void Delete(object id)
        {
            var result = GetById(id);
            if (result != null)
                Delete(result);
        }
    }
}
