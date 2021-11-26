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
    [RoutePrefix("api/option")]
    public class OptionController : ApiController
    {
        private IOptionService service;
        private readonly IMapper mapper;
        private IQuestionService questionService;

        public OptionController(IOptionService service, IMapper mapper, IQuestionService questionService)
        {
            this.service = service;
            this.mapper = mapper;
            this.questionService = questionService;
        }

        [HttpPost]
        [Route("{id}")]

        public void affect(Option option, int id)
        {
            option.Questions = questionService.GetById(id);
            service.Add(option);
            questionService.GetById(id).Options.Add(option);



        }
        [HttpGet]
        public IEnumerable<OptionDTO> GetOptions()
        {
            var entity = service.GetAll();
            return mapper.Map<IEnumerable<OptionDTO>>(entity);
        }
        [HttpGet]
        [Route("{id}")]
        public OptionDTO GetOptionById(int id)
        {
            var entity = service.GetById(id);
            return mapper.Map<OptionDTO>(entity);


        }
        [HttpGet]
        [Route("OptionByQuestion/{QuesId}")]
        public IEnumerable<OptionDTO> GetOptionsByQuestionId(int QuesId)
        {
            var entity = service.GetOptionsByQuestionId(QuesId);
            return mapper.Map<IEnumerable<OptionDTO>>(entity);


        }
        [HttpPost]
        public void add(OptionDTO o)
        {
            var entity = this.mapper.Map<Option>(o);

            service.Add(entity);
        }
        [HttpPut]
        public void update(OptionDTO o)
        {
            var entity = this.mapper.Map<Option>(o);

            service.Update(entity);
        }
        [HttpDelete]
        public void delete(Option o)
        {
            service.Delete(o);
        }
        [HttpDelete]
        [Route("{id}")]

        public void remove(int id)
        {
            service.Remove(id);
        }
    }
}
