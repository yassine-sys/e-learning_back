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
    [RoutePrefix("api/question")]
    public class QuestionController : ApiController
    {
        private IQuestionService service;
        private readonly IMapper mapper;



        public QuestionController(IQuestionService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<QuestionDTO> GetQuestions()
        {
            var entity = service.GetAll();
            return mapper.Map<IEnumerable<QuestionDTO>>(entity);

        }
        [HttpGet]
        [Route("{id}")]
        public QuestionDTO GetQuestionById(int id)
        {
            var entity = service.GetById(id);
            return mapper.Map<QuestionDTO>(entity);

        }
        [HttpGet]
        [Route("optionbyquestions/{QuesId}")]
        public IEnumerable<OptionDTO> GetOptionByQuestionID(int QuesId)
        {
            var entity = service.GetOptionByQuestionID(QuesId);
            return mapper.Map<IEnumerable<OptionDTO>>(entity);
        }
        [HttpPost]
        public void add(QuestionDTO q)
        {
            var entity = this.mapper.Map<Question>(q);

            service.Add(entity);
        }
        [HttpPut]
        public void update(QuestionDTO q)
        {
            var entity = this.mapper.Map<Question>(q);

            service.Update(entity);
        }
        [HttpDelete]
        public void delete(Question q)
        {
            service.Delete(q);
        }

    }
}
