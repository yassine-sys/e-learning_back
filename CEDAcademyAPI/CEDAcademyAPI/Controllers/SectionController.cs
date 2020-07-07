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
    [RoutePrefix("api/section")]
    public class SectionController : ApiController
    {
        private ISectionService service;

        public SectionController(ISectionService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("chapter/{ChapterId}")]
        public IHttpActionResult SectionbyChapterID(int ChapterId)
        {
            var section = service.GetSectionbyChapterId(ChapterId);
            return Ok(section);
        }
        [HttpPost]
        public HttpResponseMessage AddSection(Section section)
        {
            service.Add(section);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpPut]
        public IHttpActionResult UpdateSection(Section section)
        {
            service.Update(section);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpDelete]
        public IHttpActionResult DeleteSection(Section section)
        {
            service.Delete(section);
            return Ok(section);
        }

    }
}
