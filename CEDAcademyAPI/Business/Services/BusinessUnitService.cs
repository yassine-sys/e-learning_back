using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class BusinessUnitService : ServiceBase<BusinessUnit>, IBusinessUnitService
    {
        private IBusinessUnitRepository repo;

        public BusinessUnitService(IBusinessUnitRepository repo) : base((RepositoryBase<BusinessUnit>)repo)
        {
            this.repo = repo;
        }
       /*ublic IEnumerable<Department> GetDepartmentByBusinessUnitId(int BusinessUnitId)
        {
            return context.Departments.Where(x => x.BusinessUnit.Departments.Any(c => c.Id == BusinessUnitId));
        }
        */
       
    }
}
