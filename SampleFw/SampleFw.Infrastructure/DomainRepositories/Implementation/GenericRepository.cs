using System.Collections.Generic;
using System.Data.Entity;

namespace SampleFw.Infrastructure
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext dbContext;

        public GenericRepository()
        {
            if (dbContext == null)
            {
                dbContext = ApplicationDbContext.Create();
            }
        }

        public void Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
        }

        public IEnumerable<TEntity> GetEntities()
        {
            return dbContext.Set<TEntity>();
        }

        public TEntity GetEntity(object key)
        {
            return dbContext.Set<TEntity>().Find(key);
        }

        public void Update(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
