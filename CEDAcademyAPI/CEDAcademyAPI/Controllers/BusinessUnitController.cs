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
    [RoutePrefix("api/businessUnit")]
    public class BusinessUnitController : ApiController
    {
        private IBusinessUnitService service;

        public BusinessUnitController(IBusinessUnitService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<BusinessUnit> GetBusinessUnits()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public BusinessUnit GetBusinessUnitById(int id)
        {
            return service.GetById(id);
        }
        [HttpPost]
        public void add(BusinessUnit b)
        {
            service.Add(b);
        }
        [HttpPut]

        public void update(BusinessUnit b)
        {
            service.Update(b);
        }
        [HttpDelete]
        public void delete(BusinessUnit b)
        {
            service.Delete(b);
        }
        [HttpGet]
        [Route("getDepartmentByBusinessUnit/{BusinessUnitId}")]
        public IEnumerable<Department> GetDepartmentByBusinessUnitId(int BusinessUnitId)
        {
            return service.GetDepartmentByBusinessUnitId(BusinessUnitId);
        }


    }
}
