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
    public class ParagraphProgressController : ApiController
    {
        private IParagraphProgressService service;

        public ParagraphProgressController(IParagraphProgressService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/paragraphs/Count/{id}")]
        public IHttpActionResult CountParagraphs(int CourseId)
        {
            var NbrParagraph = service.CountParagraphs(CourseId);
            return Ok(NbrParagraph);
        }
        [HttpGet]
        [Route("api/ParagraphProgress/{id}")]
        public IHttpActionResult GetPragraphProgressBySectionI(int SectionId)
        {
            var Paragraph = service.GetParagraphProgressBySectionId(SectionId);
            return Ok(Paragraph);
        }
        [HttpGet]
        [Route("api/ParagraphProgress/{idC}/{idU}")]
        public IHttpActionResult GetParagraphProgressByCourseidUserid(int CourseId, string UserId)
        {
            var Paragraph = service.GetParagraphProgressByCourseIdUserId(CourseId, UserId);
            return Ok(Paragraph);
        }
        [HttpPost]
        [Route("api/ParagraphProgress")]
        public HttpResponseMessage AddParagraphProgress(ParagraphProgress pp)
        {
            service.Add(pp);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpPut]
        [Route("api/ParagraphProgress")]
        public IHttpActionResult UpdateParagraphProgress(ParagraphProgress pp)
        {
            service.Update(pp);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpDelete]
        [Route("api/ParagraphProgress")]
        public IHttpActionResult DeleteParagraphProgress(ParagraphProgress pp)
        {
            service.Delete(pp);
            return Ok(pp);
        }

    }
}
