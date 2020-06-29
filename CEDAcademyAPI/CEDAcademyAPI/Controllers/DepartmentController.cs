using Business.IServices;
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
    }
}
