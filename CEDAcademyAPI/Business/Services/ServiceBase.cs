using Business.IServices;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
   public class ServiceBase<TEntity> : IServiceBase<TEntity>
        where TEntity : class, IEntityBase
    {
        protected readonly RepositoryBase<TEntity> repository;

        public ServiceBase(RepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }
        public void Add(TEntity t)
        {
            this.repository.Add(t);
        }
        public void Update(TEntity t)
        {
            this.repository.update(t);
        }
        public void Delete(TEntity t)
        {
            this.repository.Delete(t);
        }
        public void Remove(int id)
        {
            this.repository.Remove(id);
        }
    }
}
