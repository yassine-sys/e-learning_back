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
        private IChapterService service;

        public ChapterController(IChapterService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/Chapters")]
        public IEnumerable<Chapter> GetChapters()
        {
            return this.service.GetChapters();
        }
        [HttpGet]
        [Route("api/Chapters/{id}")]
        public Chapter GetChapterById(int ChapterId)
        {
            return service.GetChapterById(ChapterId);
        }
        [HttpPost]
        [Route("api/Chapters")]
        public IHttpActionResult AddChapter(Chapter c)
        {
            service.AddChapter(c);
            return Ok(c);
        }
        [HttpPut]
        [Route("api/Chapters")]
        public IHttpActionResult UpdateChapter(Chapter c)
        {
            service.UpdateChapter(c);
            return Ok(c);
        }
        [HttpDelete]
        [Route("api/Chapters")]
        public IHttpActionResult DeleteChapter(Chapter c)
        {
            service.DeleteChapter(c);
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
