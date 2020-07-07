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
    [RoutePrefix("api/examResult")]
    public class ExamResultController : ApiController
    {
        private IExamResultService service;

        public ExamResultController(IExamResultService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<ExamResult> GetExamResults()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public ExamResult GetExamResultById(int id)
        {
            return service.GetById(id);
        }
        [HttpGet]
        [Route("ResultByExam/{ExamId}")]
        public IEnumerable<Exam> GetExamResultsByExamID(int ExamId)
        {
            return service.GetExamResultsByExamID(ExamId);
        }
        [HttpPost]
        public void add(ExamResult e)
        {
            service.Add(e);
        }
        [HttpPut]
        public void update(ExamResult e)
        {
            service.Update(e);
        }
        [HttpDelete]
        public void delete(ExamResult e)
        {
            service.Delete(e);
        }
    }
}
