using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class BusinessUnitRepository<BusinessUnit>: IBusinessUnitRepository<BusinessUnit> where BusinessUnit:class
    {
        private ApplicationContext context;
        public BusinessUnitRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<BusinessUnit> GetBusinessUnits()
        {
            return context.BusinessUnits.ToList();
        }
        public BusinessUnit GetBusinessUnitByID(int BusinessUnitId)
        {
            return context.BusinessUnits.Find(BusinessUnitId);
        }

        public void InsertBusinessUnit(BusinessUnit business)
        {
            context.Customers.Add(business);
        }

        public void DeleteBusinessUnit(int BusinessUnitId)
        {
            BusinessUnit business = context.BusinessUnits.Find(BusinessUnitId);
            context.BusinessUnits.Remove(business);
        }

        public void UpdateBusinessUnit(BusinessUnit business)
        {
            context.Entry(business).State = EntityState.Modified;
        }
    }
}
