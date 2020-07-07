using Business.IServices;
using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    [RoutePrefix("api/course")]
    public class CourseController : ApiController
    {
        private readonly ICourseService service;
        public CourseController(ICourseService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<Course> GetCourses()
        {
            return service.GetAll();
        }

        [HttpGet()]
        [Route("{courseId}")]
        public IHttpActionResult GetCourseById(int courseId)
        {
            var course = service.GetById(courseId);
            return Ok(course);
        }

        [HttpPost]
        public IHttpActionResult AddCourse(Course c)
        {
            service.Add(c);
            return Ok(c);
        }
        [HttpPut]
        public IHttpActionResult UpdateCourse(Course c)
        {
            service.Update(c);
            return Ok(c);
        }
        [HttpDelete]
        public IHttpActionResult DeleteCourse(Course c)
        {
            service.Delete(c);
            return Ok(c);
        }

        [HttpGet]
        [Route("count")]
        public IHttpActionResult GetCoursesCount()
        {
            var count = service.GetCoursesCount();
            return Ok(count);
        }
    }
}
