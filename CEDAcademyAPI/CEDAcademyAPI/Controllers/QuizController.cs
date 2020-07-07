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
    [RoutePrefix("api/quiz")]
    public class QuizController : ApiController
    {
        private IQuizService service;

        public QuizController(IQuizService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<Quiz> GetQuizzes()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public Quiz GetQuizById(int id)
        {
            return service.GetById(id);
        }
        [HttpGet]
        [Route("questionbyquiz/{QuizId}")]

        public IEnumerable<Question> GetQuestionByQuizID(int QuizId)
        {
            return service.GetQuestionByQuizID(QuizId);
        }
        [HttpPost]
        public void add(Quiz q)
        {
            service.Add(q);
        }
        [HttpPut]
        public void update(Quiz q)
        {
            service.Update(q);
        }
        [HttpDelete]
        public void delete(Quiz q)
        {
            service.Delete(q);
        }
    }
}
