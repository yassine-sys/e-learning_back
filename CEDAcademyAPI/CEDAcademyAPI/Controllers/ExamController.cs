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
    public class ExamController : ApiController
    {
        private IExamService service;

        public ExamController(IExamService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/Exam")]
        public IEnumerable<Exam> GetExams()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("api/Exam/{id}")]
        public Exam GetExamById(int id)
        {
            return service.GetById(id);
            
        }
        [HttpGet]
        [Route("api/QuestionByExam/{id}")]
        public IEnumerable<Question> GetQuestionByExamID(int ExamID)
        {
            return service.GetQuestionByExamID(ExamID);
        }
        [HttpPost]
        [Route("api/Exam/add")]
        public void add(Exam e)
        {
            service.Add(e);
        }
        [HttpPut]
        [Route("api/Exam/update")]
        public void update(Exam e)
        {
            service.Update(e);
        }
        [HttpDelete]
        [Route("api/Exam/delete")]
        public void delete(Exam e)
        {
            service.Delete(e);
        }
    }
}
