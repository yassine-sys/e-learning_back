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
    public class ChapterController : ApiController
    {
        private readonly IChapterService service;

        public ChapterController(IChapterService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/Chapters")]
        public IEnumerable<Chapter> GetChapters()
        {
            return this.service.GetAll();
        }
        [HttpGet]
        [Route("api/Chapters/{id}")]
        public Chapter GetChapterById(int ChapterId)
        {
            return service.GetById(ChapterId);
        }
        [HttpPost]
        [Route("api/Chapters")]
        public HttpResponseMessage AddChapter(Chapter c)
        {
            service.Add(c);
            return Request.CreateResponse(HttpStatusCode.Created);

        }
        [HttpPut]
        [Route("api/Chapters")]
        public IHttpActionResult UpdateChapter(Chapter c)
        {
            service.Update(c);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpDelete]
        [Route("api/Chapters")]
        public IHttpActionResult DeleteChapter(Chapter c)
        {
            service.Delete(c);
            return Ok(c);
        }
        [HttpGet]
        [Route("api/Chapter/Course/{id}")]
        public IHttpActionResult GetChapterbyCourseID(int CourseId)
        {
            var Chapters = service.GetChapterbyCourseId(CourseId);
            return Ok(Chapters);
        }
        [HttpGet]
        [Route("api/Chapters/Course/{id}")]
        public IHttpActionResult GetChapterDetailsByCourseID(int CourseId)
        {
            var ChaptersDetails = service.GetChapterDetailsByCourseID(CourseId);
            return Ok(ChaptersDetails);
        }
    }
}
