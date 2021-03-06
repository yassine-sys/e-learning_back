using AutoMapper;
using Business.IServices;
using Entities.Models;
using Entities.ModelsDTO;
using System.Collections.Generic;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    [RoutePrefix("api/businessUnit")]
    public class BusinessUnitController : ApiController
    {
        private IBusinessUnitService service;
        private readonly IMapper mapper;

        public BusinessUnitController(IBusinessUnitService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
       


        [HttpGet]
        public IEnumerable<BusinessUnitDTO> GetBusinessUnits()
        {
            var x = service.GetAll();
            return mapper.Map<IEnumerable<BusinessUnitDTO>>(x);
            // return service.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public BusinessUnitDTO GetBusinessUnitById(int id)
        {

            var x= service.GetById(id);
            return mapper.Map <BusinessUnitDTO> (x);

        } 
       
        
        [HttpPost]
        public void add(BusinessUnitDTO b)
        {
            var entity = this.mapper.Map<BusinessUnit>(b);
            service.Add(entity);
        }

        [HttpPut]

        public void update(BusinessUnitDTO b)
        {
            var entity = this.mapper.Map<BusinessUnit>(b);
            service.Update(entity);
        }
        [HttpDelete]
        public void delete(BusinessUnit b)
        {
            service.Delete(b);
        }
        [HttpDelete]
        [Route("{id}")]

        public void remove(int id)
        {
            service.Remove(id);
        }
        [HttpGet]
        [Route("getDepartmentByBusinessUnit/{BusinessUnitId}")]
        public IEnumerable<Department> GetDepartmentByBusinessUnitId(int BusinessUnitId)
        {
            return service.GetDepartmentByBusinessUnitId(BusinessUnitId);
        }


    }
}
