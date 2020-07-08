using AutoMapper;
using Business.IServices;
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


        public DepartmentController(IDepartmentService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
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
    }
}
