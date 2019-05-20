using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SampleFw.IRepository.Common
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetEntities();

        IEnumerable<TEntity> GetEntities(Expression<Func<TEntity, bool>> predicate);

        TEntity GetEntity(object id);

        Task<TEntity> GetEntityAsync(object id);

        void Add(TEntity entity);

        Task AddAsync(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entities);

    }
}
