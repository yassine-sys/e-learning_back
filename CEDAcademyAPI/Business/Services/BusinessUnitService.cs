using Business.IServices;
using DataAccess.Infrastructure;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class BusinessUnitService: IBusinessUnitService
    {
        private CEDAcademyDbContext context;
        public BusinessUnitService(CEDAcademyDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Department> GetDepartmentByBusinessUnitId(int BusinessUnitId)
        {
            return context.Departments.Where(x => x.BusinessUnit.Departments.Any(c => c.Id == BusinessUnitId));
        }

       
    }
}
