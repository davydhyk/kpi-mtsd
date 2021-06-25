using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces.Repositories;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class GenericRepository<TKey, TEntity>: IGenericRepository<TKey, TEntity> where TEntity: BaseEntity<TKey>
    {
        protected readonly ShopContext context;
        private readonly DbSet<TEntity> table;

        public GenericRepository(ShopContext context)
        {
            this.context = context;
            this.table = this.context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            table.Add(entity);
            this.context.SaveChanges();
        }

        public void Delete(TKey key)
        {
            TEntity obj = table.Find(key);
            table.Remove(obj);
            this.context.SaveChanges();
        }

        public TEntity Read(TKey key)
        {
            return table.Find(key);
        }

        public virtual IList<TEntity> ReadAll()
        {
            return table.ToList();
        }

        public void Update(TEntity entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            this.context.SaveChanges();
        }
    }
}