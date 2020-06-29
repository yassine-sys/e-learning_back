using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class DepartmentRepository : RepositoryBase<CEDAcademyDbContext, Department>, IDepartmentRepository
    {
        public DepartmentRepository(CEDAcademyDbContext db)
            : base(db)
        {
        }
    }
}
