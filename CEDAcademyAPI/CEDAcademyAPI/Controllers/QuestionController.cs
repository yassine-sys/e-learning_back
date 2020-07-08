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
    [RoutePrefix("api/question")]
    public class QuestionController : ApiController
    {
        private IQuestionService service;

        public QuestionController(IQuestionService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<Question> GetQuestions()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public Question GetQuestionById(int id)
        {
            return service.GetById(id);
        }
        [HttpGet]
        [Route("optionbyquestions/{QuesId}")]
        public IEnumerable<Option> GetOptionByQuestionID(int QuesId)
        {
            return service.GetOptionByQuestionID(QuesId);
        }
        [HttpPost]
        public void add(Question q)
        {
            service.Add(q);
        }
        [HttpPut]
        public void update(Question q)
        {
            service.Update(q);
        }
        [HttpDelete]
        public void delete(Question q)
        {
            service.Delete(q);
        }

    }
}
