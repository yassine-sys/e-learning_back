using Business.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class BusinessUnitController : ApiController
    {
        private IBusinessUnitService service;

        public BusinessUnitController(IBusinessUnitService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/get_business_unit")]
        public IEnumerable<BusinessUnit> GetBusinessUnits()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("api/get_business_unit/{id}")]
        public BusinessUnit GetBusinessUnitById(int id)
        {
            return service.GetById(id);
        }
        [HttpPost]
        [Route("api/add_business_unit")]
        public void add(BusinessUnit b)
        {
            service.Add(b);
        }
        [HttpPut]
        [Route("api/update_business_unit")]

        public void update(BusinessUnit b)
        {
            service.Update(b);
        }
        [HttpDelete]
        [Route("api/delete_business_unit")]
        public void delete(BusinessUnit b)
        {
            service.Delete(b);
        }
        [HttpGet]
        [Route("api/get_department_by_business_unit/{id}")]
        public IEnumerable<Department> GetDepartmentByBusinessUnitId(int BusinessUnitId)
        {
            return service.GetDepartmentByBusinessUnitId(BusinessUnitId);
        }


    }
}
