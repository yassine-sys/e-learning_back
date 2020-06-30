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
    public class QuizController : ApiController
    {
        private IQuizService service;

        public QuizController(IQuizService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/quiz")]
        public IEnumerable<Quiz> GetQuizzes()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("api/quiz/{id}")]

        public Quiz GetQuizById(int id)
        {
            return service.GetById(id);
        }
        [HttpGet]
        [Route("api/questionbyquiz/{id}")]

        public IEnumerable<Question> GetQuestionByQuizID(int QuizId)
        {
            return service.GetQuestionByQuizID(QuizId);
        }
        [HttpPost]
        [Route("api/quiz/add")]


        public void add(Quiz q)
        {
            service.Add(q);
        }
        [HttpPut]
        [Route("api/quiz/update")]


        public void update(Quiz q)
        {
            service.Update(q);
        }
        [HttpDelete]
        [Route("api/quiz/delete")]

        public void delete(Quiz q)
        {
            service.Delete(q);
        }
    }
}
