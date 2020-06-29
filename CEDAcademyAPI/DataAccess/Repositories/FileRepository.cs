using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class FileRepository : RepositoryBase<CEDAcademyDbContext, File>, IFileRepository
    {
        public FileRepository(CEDAcademyDbContext db)
            : base(db)
        {
        }
    }
}
