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
    public class ParagraphController : ApiController
    {
        private IParagraphService service;

        public ParagraphController(IParagraphService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/Paragraph/Section/{id}")]
        public IHttpActionResult ParagraphbySectionID(int SectionId)
        {
            var paragraphs = service.GetParagraphbySectionID(SectionId);
            return Ok(paragraphs);
        }
        [HttpGet]
        [Route("api/Paragraphs")]
        public IEnumerable<Paragraph> GetChapteParagraphs()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("api/Paragraph/{id}")]
        public Paragraph GetParagraphById(int ParagraphId)
        {
            return service.GetById(ParagraphId);
        }
        [HttpPost]
        [Route("api/Paragraph")]
        public HttpResponseMessage AddChapter(Paragraph p)
        {
            service.Add(p);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpPut]
        [Route("api/Paragraph")]
        public IHttpActionResult UpdateChapter(Paragraph p)
        {
            service.Update(p);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpDelete]
        [Route("api/Paragraph")]
        public IHttpActionResult DeleteParagraph(Paragraph p)
        {
            service.Delete(p);
            return Ok(p);
        }
    }
}
