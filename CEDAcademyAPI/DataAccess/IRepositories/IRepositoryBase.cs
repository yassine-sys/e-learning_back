using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Infrastructure;


namespace DataAccess.IRepositories
{
    public interface IRepositoryBase<TContext, TEntity>
        where TContext : CEDAcademyDbContext
        where TEntity : class
    {
    }
}
