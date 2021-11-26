using AutoMapper;
using Business.IServices;
using Business.Services;
using Entities.Models;
using Entities.ModelsDTO;
using System.Collections.Generic;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    [RoutePrefix("api/department")]
    public class DepartmentController : ApiController
    {
        private IDepartmentService service;
        private readonly IMapper mapper;
        private IBusinessUnitService BusinessUnitService;

        public DepartmentController(IDepartmentService service, IMapper mapper,IBusinessUnitService BusinessUnitService)
        {
            this.service = service;
            this.mapper = mapper;
            this.BusinessUnitService = BusinessUnitService;
        }
        [HttpPost]
        [Route("{id}")]

        public void affect(Department department,int id)
        {
            department.BusinessUnit = BusinessUnitService.GetById(id);
            service.Add(department);
            BusinessUnitService.GetById(id).Departments.Add(department);



        }




        [HttpGet]
        public IEnumerable<DepartmentDTO> GetDepartments()
        {
            var entity = service.GetAll();
            return mapper.Map<IEnumerable<DepartmentDTO>>(entity);

        }
        [HttpGet]
        [Route("{id}")]
        public DepartmentDTO GetDepartmentById(int id)
        {
            var entity = service.GetById(id);
            return mapper.Map<DepartmentDTO>(entity);
        }
        [HttpPost]
        public void add(DepartmentDTO d)
        {
            var entity = this.mapper.Map<Department>(d);
            service.Add(entity);
        }
        [HttpPut]
        public void update(DepartmentDTO d)
        {
            var entity = this.mapper.Map<Department>(d);

            service.Update(entity);
        }
        [HttpDelete]
        public void delete(Department d)
        {
            service.Delete(d);
        }
        [HttpDelete]
        [Route("{id}")]

        public void remove(int id)
        {
            service.Remove(id);
        }
    }
}
