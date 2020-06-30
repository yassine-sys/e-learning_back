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
    public class ParagraphProgressRepository : RepositoryBase<ParagraphProgress>, IParagraphProgressRepository
    {
        public ParagraphProgressRepository(CEDAcademyDbContext db)
            : base(db)
        {
        }

    }
}
