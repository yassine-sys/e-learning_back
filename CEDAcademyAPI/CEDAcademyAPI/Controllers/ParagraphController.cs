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
    [RoutePrefix("api/paragraph")]
    public class ParagraphController : ApiController
    {
        private IParagraphService service;

        public ParagraphController(IParagraphService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("Section/{SectionId}")]
        public IHttpActionResult ParagraphbySectionID(int SectionId)
        {
            var paragraphs = service.GetParagraphbySectionID(SectionId);
            return Ok(paragraphs);
        }
        [HttpGet]
        public IEnumerable<Paragraph> GetChapteParagraphs()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("{ParagraphId}")]
        public Paragraph GetParagraphById(int ParagraphId)
        {
            return service.GetById(ParagraphId);
        }
        [HttpPost]
        public HttpResponseMessage AddChapter(Paragraph p)
        {
            service.Add(p);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpPut]
        public IHttpActionResult UpdateChapter(Paragraph p)
        {
            service.Update(p);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpDelete]
        public IHttpActionResult DeleteParagraph(Paragraph p)
        {
            service.Delete(p);
            return Ok(p);
        }
    }
}
