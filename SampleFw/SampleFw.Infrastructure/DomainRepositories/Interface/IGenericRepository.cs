using System.Collections.Generic;

namespace SampleFw.Infrastructure
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetEntities();

        TEntity GetEntity(object key);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
