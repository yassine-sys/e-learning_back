using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class CourseController : ApiController
    {
        private ICourseService service;

        public CourseController(ICourseService service)
        {
            this.service = service;
        }
    }
}
