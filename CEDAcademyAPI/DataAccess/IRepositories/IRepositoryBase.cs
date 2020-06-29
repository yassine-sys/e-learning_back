using System.Data.Entity;


namespace DataAccess.IRepositories
{
    public interface IRepositoryBase<TContext, TEntity>
        where TContext : DbContext
        where TEntity : class
    {
    }
}
