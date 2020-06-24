using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    class BusinessUnitService<Department> : IBusinessUnitService<Department> where Department:class
    {
        private ApplicationContext context;
        public BusinessUnitService(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Department> GetDepartmentByBusinessUnitId(int BusinessUnitId)
        {
            return context.Departments.Where(x => x.BusinessUnit.Departments.Any(c => c.BusinessUnitId == BusinessUnitId));
        }

       
    }
}
