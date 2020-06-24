using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RepositoryBase<TContext, TEntity> : IRepositoryBase<TContext,TEntity> 
        where TContext : CEDAcademyDbContext
        where TEntity : class
    {
        readonly CEDAcademyDbContext db;
        readonly DbSet<TEntity> dbSet;
        public RepositoryBase(CEDAcademyDbContext db)
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

        
    }
}