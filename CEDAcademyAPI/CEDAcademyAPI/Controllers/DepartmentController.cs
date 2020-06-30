using Business.IServices;
using Entities.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        private IDepartmentService service;

        public DepartmentController(IDepartmentService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/department")]
        public IEnumerable<Department> GetDepartments()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("api/department/{id}")]

        public Department GetDepartmentById(int id)
        {
            return service.GetById(id);
        }
        [HttpPost]
        [Route("api/department/add")]

        public void add(Department d)
        {
            service.Add(d);
        }
        [HttpPut]
        [Route("api/department/update")]

        public void update(Department d)
        {
            service.Update(d);
        }
        [HttpDelete]
        [Route("api/department/delete")]

        public void delete(Department d)
        {
            service.Delete(d);
        }
    }
}
