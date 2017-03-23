using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProductManagement.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        public Repository(DbContext context)
        {
            this.Context = context;
        }
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }
        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }
        public TEntity Get(int entityId)
        {
            return Context.Set<TEntity>().Find(entityId);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList<TEntity>();
        }
        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

    }
}
