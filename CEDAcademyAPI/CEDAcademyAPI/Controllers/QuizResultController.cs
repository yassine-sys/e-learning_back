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
    [RoutePrefix("api/quizResult")]
    public class QuizResultController : ApiController
    {
        private IQuizResultService service;

        public QuizResultController(IQuizResultService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<QuizResult> GetQuizResults()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("{id}")]

        public QuizResult GetQuizResultById(int id)
        {
            return service.GetById(id);
        }
        [HttpGet]
        [Route("quizresultbyquiz/{QuizId}")]
        public IEnumerable<QuizResult> GetQuizResultsByQuizID(int QuizId)
        {
            return service.GetQuizResultsByQuizID(QuizId);
        }
        [HttpPost]
        public void add(QuizResult q)
        {
            service.Add(q);
        }
        [HttpPut]
        public void update(QuizResult q)
        {
            service.Update(q);
        }
        [HttpDelete]
        public void delete(QuizResult q)
        {
            service.Delete(q);
        }
    }
}
