using AutoMapper;
using Business.IServices;
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
    [RoutePrefix("api/chapter")]
    public class ChapterController : ApiController
    {
        private readonly IChapterService service;
        private readonly IMapper mapper;
        public ChapterController(IChapterService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<ChapterDTO> GetChapters()
        {
            var ch = service.GetAll();
            return mapper.Map<IEnumerable<ChapterDTO>>(ch);
        }
        [HttpGet]
        [Route("{ChapterId}")]
        public ChapterDTO GetChapterById(int ChapterId)
        {
            var ch = service.GetById(ChapterId);
            return mapper.Map<ChapterDTO>(ch);
        }
        [HttpPost]
        public void AddChapter(ChapterDTO c)
        {
            var ch = this.mapper.Map<Chapter>(c);
            service.Add(ch);
        }
        [HttpPut]
        public void UpdateChapter(Chapter c)
        {
            var ch = this.mapper.Map<Chapter>(c);
            service.Update(ch);
        }
        [HttpDelete]
        public IHttpActionResult DeleteChapter(Chapter c)
        {
            service.Delete(c);
            return Ok(c);
        }
        [HttpGet]
        [Route("course/{CourseId}")]
        public IEnumerable<ChapterDTO> GetChapterbyCourseID(int CourseId)
        {
            var Chapters = service.GetChapterbyCourseId(CourseId);
            return mapper.Map<IEnumerable<ChapterDTO>>(Chapters);
        }
        [HttpGet]
        [Route("Details/{CourseId}")]
        public IEnumerable<ChapterDTO> GetChapterDetailsByCourseID(int CourseId)
        {
            var ChaptersDetails = service.GetChapterDetailsByCourseID(CourseId);
            return mapper.Map<IEnumerable<ChapterDTO>>(ChaptersDetails);
        }
    }
}
