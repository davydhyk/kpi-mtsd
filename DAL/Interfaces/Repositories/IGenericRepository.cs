using System.Collections.Generic;
using Entity;

namespace DAL.Interfaces.Repositories
{
    public interface IGenericRepository<TKey, TEntity> where TEntity: BaseEntity<TKey>
    {
        void Create(TEntity entity);

        TEntity Read(TKey key);

        void Update(TEntity entity);

        void Delete(TKey key);

        IList<TEntity> ReadAll();
    }
}