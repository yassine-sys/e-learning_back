using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{

    public interface IServiceBase<TEntity>    
      where TEntity : class, IEntityBase
        {
            TEntity GetById(int id);
            IEnumerable<TEntity> GetAll();
            void Add(TEntity t);
            void Update(TEntity t);
            void Delete(TEntity t);
        }
    
}
