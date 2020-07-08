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
    [RoutePrefix("api/section")]
    public class SectionController : ApiController
    {
        private readonly ISectionService service;
        private readonly IMapper mapper;
        public SectionController(ISectionService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("chapter/{ChapterId}")]
        public IEnumerable<SectionDTO> SectionbyChapterID(int ChapterId)
        {
            var section = service.GetSectionbyChapterId(ChapterId);
            return mapper.Map<IEnumerable<SectionDTO>>(section);
        }
        [HttpPost]
        public void AddSection(SectionDTO section)
        {
            var s = this.mapper.Map<Section>(section);
            service.Add(s);
        }
        [HttpPut]
        public void UpdateSection(Section section)
        {
            var s = this.mapper.Map<Section>(section);
            service.Update(s);
        }
        [HttpDelete]
        public IHttpActionResult DeleteSection(Section section)
        {
            service.Delete(section);
            return Ok(section);
        }

    }
}
