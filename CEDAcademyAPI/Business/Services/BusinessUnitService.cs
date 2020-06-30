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
        private IDepartmentRepository departmentRepository;
        public BusinessUnitService(IBusinessUnitRepository repo, IDepartmentRepository departmentRepository) : base((RepositoryBase<BusinessUnit>)repo)
        {
            this.repo = repo;
            this.departmentRepository = departmentRepository;
        }

        public IEnumerable<Department> GetDepartmentByBusinessUnitId(int BusinessUnitId)
        {
            return departmentRepository.GetAll().Where(x => x.BusinessUnitId == BusinessUnitId);
        }
       

    }
}
