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
    [RoutePrefix("api/exam")]
    public class ExamController : ApiController
    {
        private IExamService service;

        public ExamController(IExamService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<Exam> GetExams()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public Exam GetExamById(int id)
        {
            return service.GetById(id);
            
        }
        [HttpGet]
        [Route("QuestionByExam/{ExamId}")]
        public IEnumerable<Question> GetQuestionByExamID(int ExamId)
        {
            return service.GetQuestionByExamID(ExamId);
        }
        [HttpPost]
        public void add(Exam e)
        {
            service.Add(e);
        }
        [HttpPut]
        public void update(Exam e)
        {
            service.Update(e);
        }
        [HttpDelete]
        public void delete(Exam e)
        {
            service.Delete(e);
        }
    }
}
