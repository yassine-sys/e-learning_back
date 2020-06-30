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
    public class SectionController : ApiController
    {
        private ISectionService service;

        public SectionController(ISectionService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/Section/Chapter/{id}")]
        public IHttpActionResult SectionbyChapterID(int ChapterId)
        {
            var section = service.GetSectionbyChapterId(ChapterId);
            return Ok(section);
        }
        [HttpPost]
        [Route("api/Section")]
        public HttpResponseMessage AddSection(Section section)
        {
            service.AddSection(section);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpPut]
        [Route("api/Section")]
        public IHttpActionResult UpdateSection(Section section)
        {
            service.UpdateSection(section);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpDelete]
        [Route("api/Section")]
        public IHttpActionResult DeleteSection(Section section)
        {
            service.DeleteSection(section);
            return Ok(section);
        }

    }
}
