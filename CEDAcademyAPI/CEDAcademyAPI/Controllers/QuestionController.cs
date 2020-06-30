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
    public class QuestionController : ApiController
    {
        private IQuestionService service;

        public QuestionController(IQuestionService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/questions")]
        public IEnumerable<Question> GetQuestions()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("api/questions/{id}")]
        public Question GetQuestionById(int id)
        {
            return service.GetById(id);
        }
        [HttpGet]
        [Route("api/optionbyquestions/{id}")]

        public IEnumerable<Option> GetOptionByQuestionID(int QuesId)
        {
            return service.GetOptionByQuestionID(QuesId);
        }
        [HttpPost]
        [Route("api/questions/add")]
        public void add(Question q)
        {
            service.Add(q);
        }
        [HttpPut]
        [Route("api/questions/update")]
        public void update(Question q)
        {
            service.Update(q);
        }
        [HttpDelete]
        [Route("api/questions/delete")]
        public void delete(Question q)
        {
            service.Delete(q);
        }

    }
}
