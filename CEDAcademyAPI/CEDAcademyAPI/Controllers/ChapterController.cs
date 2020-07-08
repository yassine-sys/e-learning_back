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
    [RoutePrefix("api/chapter")]
    public class ChapterController : ApiController
    {
        private readonly IChapterService service;

        public ChapterController(IChapterService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<Chapter> GetChapters()
        {
            return this.service.GetAll();
        }
        [HttpGet]
        [Route("{ChapterId}")]
        public Chapter GetChapterById(int ChapterId)
        {
            return service.GetById(ChapterId);
        }
        [HttpPost]
        public HttpResponseMessage AddChapter(Chapter c)
        {
            service.Add(c);
            return Request.CreateResponse(HttpStatusCode.Created);

        }
        [HttpPut]
        public IHttpActionResult UpdateChapter(Chapter c)
        {
            service.Update(c);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpDelete]
        public IHttpActionResult DeleteChapter(Chapter c)
        {
            service.Delete(c);
            return Ok(c);
        }
        [HttpGet]
        [Route("course/{CourseId}")]
        public IHttpActionResult GetChapterbyCourseID(int CourseId)
        {
            var Chapters = service.GetChapterbyCourseId(CourseId);
            return Ok(Chapters);
        }
        [HttpGet]
        [Route("Details/{CourseId}")]
        public IHttpActionResult GetChapterDetailsByCourseID(int CourseId)
        {
            var ChaptersDetails = service.GetChapterDetailsByCourseID(CourseId);
            return Ok(ChaptersDetails);
        }
    }
}
