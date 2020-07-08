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
    [RoutePrefix("api/paragraph")]
    public class ParagraphController : ApiController
    {
        private readonly IParagraphService service;
        private readonly IMapper mapper;

        public ParagraphController(IParagraphService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("Section/{SectionId}")]
        public IEnumerable<ParagraphDTO> ParagraphbySectionID(int SectionId)
        { 
            var paragraphs = service.GetParagraphbySectionID(SectionId);
            return mapper.Map< IEnumerable<ParagraphDTO>>(paragraphs);
        }
        [HttpGet]
        public IEnumerable<ParagraphDTO> GetChapteParagraphs()
        {
            var paragraphs = service.GetAll();
            return mapper.Map<IEnumerable<ParagraphDTO>>(paragraphs);
        }
        [HttpGet]
        [Route("{ParagraphId}")]
        public ParagraphDTO GetParagraphById(int ParagraphId)
        {
            var p =service.GetById(ParagraphId);
            return mapper.Map<ParagraphDTO>(p);
        }
        [HttpPost]
        public void AddParagraph(ParagraphDTO p)
        {
            var parag = this.mapper.Map<Paragraph>(p);
            service.Add(parag);
        }
        [HttpPut]
        public void UpdateChapter(ParagraphDTO p)
        {
            var parag = this.mapper.Map<Paragraph>(p);
            service.Update(parag);
        }
        [HttpDelete]
        public IHttpActionResult DeleteParagraph(Paragraph p)
        {
            service.Delete(p);
            return Ok(p);
        }
    }
}
