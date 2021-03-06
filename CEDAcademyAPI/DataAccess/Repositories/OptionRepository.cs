using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public class OptionRepository : RepositoryBase<Option>, IOptionRepository
    {
        public OptionRepository(CEDAcademyDbContext db)
            : base(db)
        {
        }
    }
}
