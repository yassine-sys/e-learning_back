using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class SectionRepository : RepositoryBase<CEDAcademyDbContext, Section>, ISectionRepository
    {
        public SectionRepository(CEDAcademyDbContext db)
            : base(db)
        {
        }

    }
}
