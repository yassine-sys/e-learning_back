using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class BusinessUnitRepository : IRepositoryBase<CEDAcademyDbContext, BusinessUnit>, IBusinessUnitRepository
    {

    }
}
