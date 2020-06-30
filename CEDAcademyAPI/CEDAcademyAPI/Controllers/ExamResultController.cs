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
    public class ExamResultController : ApiController
    {
        private IExamResultService service;

        public ExamResultController(IExamResultService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/ExamResult")]
        public IEnumerable<ExamResult> GetExamResults()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("api/ExamResult/{id}")]

        public ExamResult GetExamResultById(int id)
        {
            return service.GetById(id);
        }
        [HttpGet]
        [Route("api/ExamResultByExam/{id}")]


        public IEnumerable<Exam> GetExamResultsByExamID(int ExamID)
        {
            return service.GetExamResultsByExamID(ExamID);
        }
        [HttpPost]
        [Route("api/ExamResult/add")]


        public void add(ExamResult e)
        {
            service.Add(e);
        }
        [HttpPut]
        [Route("api/ExamResult/update")]

        public void update(ExamResult e)
        {
            service.Update(e);
        }
        [HttpDelete]
        [Route("api/ExamResult/delete")]

        public void delete(ExamResult e)
        {
            service.Delete(e);
        }
    }
}
