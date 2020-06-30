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
    public class QuizResultController : ApiController
    {
        private IQuizResultService service;

        public QuizResultController(IQuizResultService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/quizresult")]
        public IEnumerable<QuizResult> GetQuizResults()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("api/quizresult/{id}")]

        public QuizResult GetQuizResultById(int id)
        {
            return service.GetById(id);
        }
        [HttpGet]
        [Route("api/quizresultbyquiz/{id}")]

        public IEnumerable<QuizResult> GetQuizResultsByQuizID(int QuizId)
        {
            return service.GetQuizResultsByQuizID(QuizId);
        }
        [HttpPost]
        [Route("api/quizresult/add")]

        public void add(QuizResult q)
        {
            service.Add(q);
        }
        [HttpPut]
        [Route("api/quizresult/update")]

        public void update(QuizResult q)
        {
            service.Update(q);
        }
        [HttpDelete]
        [Route("api/quizresult/delete")]

        public void delete(QuizResult q)
        {
            service.Delete(q);
        }
    }
}
