using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class BusinessUnitRepository : RepositoryBase<BusinessUnit>, IBusinessUnitRepository
    {
        public BusinessUnitRepository(CEDAcademyDbContext db)
            : base(db)
        {
        }

    }
}
