using Business.IServices;
using Entities.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    [RoutePrefix("api/department")]
    public class DepartmentController : ApiController
    {
        private IDepartmentService service;

        public DepartmentController(IDepartmentService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<Department> GetDepartments()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public Department GetDepartmentById(int id)
        {
            return service.GetById(id);
        }
        [HttpPost]
        public void add(Department d)
        {
            service.Add(d);
        }
        [HttpPut]
        public void update(Department d)
        {
            service.Update(d);
        }
        [HttpDelete]
        public void delete(Department d)
        {
            service.Delete(d);
        }
    }
}
