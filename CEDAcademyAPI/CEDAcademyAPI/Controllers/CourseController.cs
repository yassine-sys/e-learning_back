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
    public class CourseController : ApiController
    {
        private ICourseService service;

        public CourseController(ICourseService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/Courses")]
        public IEnumerable<Course> GetCourses()
        {
            return service.GetAll();
        }
        [HttpGet()]
        [Route("api/Course/{id}")]
        public IHttpActionResult GetCourseById(int CourseId)
        {
            var course = service.GetById(CourseId);
            return Ok(course);
        }
        [HttpPost]
        [Route("api/Courses")]
        public IHttpActionResult AddCourse(Course c)
        {
            service.Add(c);
            return Ok(c);
        }
        [HttpPut]
        [Route("api/Courses")]
        public IHttpActionResult UpdateCourse(Course c)
        {
            service.Update(c);
            return Ok(c);
        }
        [HttpDelete]
        [Route("api/Courses")]
        public IHttpActionResult DeleteCourse(Course c)
        {
            service.Delete(c);
            return Ok(c);
        }

        [HttpGet]
        [Route("api/CourseNumber")]
        public IHttpActionResult GetCourseNumber()
        {
            var CourseNumber = service.GetCourseNumber();
            return Ok(CourseNumber);
        }
    }
}
