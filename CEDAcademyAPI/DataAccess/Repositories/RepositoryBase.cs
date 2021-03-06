using DataAccess.IRepositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<DbContext, TEntity>
       // where TContext : DbContext
        where TEntity : class
    {
        readonly DbContext db;
        readonly DbSet<TEntity> dbSet;

        public RepositoryBase(DbContext db)
        {
            this.db = db;
            this.dbSet = db.Set<TEntity>();
        }

        public TEntity GetById (int id)
        {
            return this.dbSet.Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }
        public void Add(TEntity t)
        {
            dbSet.Add(t);
            db.SaveChanges();
            
        }
        public void update(TEntity t) 
        {
            dbSet.Attach(t);
            db.Entry(t).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete (TEntity t)
        {
            if (db.Entry(t).State == EntityState.Detached)
            {
                dbSet.Attach(t);
                dbSet.Remove(t);
                db.SaveChanges();
            }
        }
        public void Remove(int id)
        {
            TEntity t = dbSet.Find(id);
            dbSet.Remove(t);
            db.SaveChanges();

        }
    }
}