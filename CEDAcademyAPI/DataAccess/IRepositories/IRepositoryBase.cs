using System.Collections.Generic;
using System.Data.Entity;


namespace DataAccess.IRepositories
{
    public interface IRepositoryBase<TContext, TEntity>
        where TContext : DbContext
        where TEntity : class
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
        
        void Add(TEntity t);
        
        void update(TEntity t);
        
        void Delete(TEntity t);
    }
}
