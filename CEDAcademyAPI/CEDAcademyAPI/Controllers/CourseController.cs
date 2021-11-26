using AutoMapper;
using Business.IServices;
using Business.Services;
using Entities.Models;
using Entities.ModelsDTO;
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
        private readonly IMapper mapper;
        public CourseController(ICourseService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<CourseDTO> GetCourses()
        {
            var x = service.GetAll();
            return mapper.Map<IEnumerable<CourseDTO>>(x);
        }

        [HttpGet()]
        [Route("{courseId}")]
        public CourseDTO GetCourseById(int courseId)
        {
            var course = service.GetById(courseId);
            return mapper.Map<CourseDTO>(course);
        }

        [HttpPost]
        public void AddCourse(CourseDTO c)
        {
            var course = this.mapper.Map<Course>(c);
            service.Add(course);
        }
        [HttpPut]
        public void UpdateCourse(CourseDTO c)
        {
            var course = this.mapper.Map<Course>(c);
            service.Update(course);
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

        [HttpPost]
        [Route("uploadimage")]
        public void UploadFile()
        {
            service.UploadFile();
        }
        [HttpGet]
        [Route("GetImage/{id}")]
        public byte[] GetImage(int id)
        {
            return service.GetImage(id);
        }
    }
}
