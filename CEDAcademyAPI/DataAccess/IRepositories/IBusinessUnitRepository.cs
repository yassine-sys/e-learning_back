using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    interface IBusinessUnitRepository<BusinessUnit> where BusinessUnit:class
    {
        IEnumerable<BusinessUnit> GetBusinessUnits();
        BusinessUnit GetBusinessUnitByID(int BusinessUnitId);
        void InsertBusinessUnit(BusinessUnit business);
        void DeleteBusinessUnit(int customerId);
        void UpdateBusinessUnit(BusinessUnit business);
    }
}
