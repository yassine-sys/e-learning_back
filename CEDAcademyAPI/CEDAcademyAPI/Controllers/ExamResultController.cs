using AutoMapper;
using Business.IServices;
using Entities.Models;
using Entities.ModelsDTO;
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
        private readonly IMapper mapper;
        private IExamService examService;


        public ExamResultController(IExamResultService service, IExamService examService, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
            this.examService = examService;
        }
        [HttpGet]
        public IEnumerable<ExamResultDTO> GetExamResults()
        {
            var entity = service.GetAll();
            return mapper.Map<IEnumerable<ExamResultDTO>>(entity);
        }
        [HttpGet]
        [Route("{id}")]
        public ExamResultDTO GetExamResultById(int id)
        {
            var entity = service.GetById(id);
            return mapper.Map<ExamResultDTO>(entity);

        }
        [HttpGet]
        [Route("ResultByExam/{ExamId}")]
        public IEnumerable<ExamDTO> GetExamResultsByExamID(int ExamId)
        {
            var entity = service.GetExamResultsByExamID(ExamId);
            return mapper.Map<IEnumerable<ExamDTO>>(entity);
        }
        [HttpPost]
        public void add(ExamResult e)
        {
            var entity = this.mapper.Map<ExamResult>(e);

            service.Add(entity);
        }
        [HttpPost]
        [Route("{id}")]

        public void affect(ExamResult examResult, int id)
        {
            examResult.Exam = examService.GetById(id);
            service.Add(examResult);
            examService.GetById(id).ExamResults.Add(examResult);



        }
        [HttpPut]
        public void update(ExamResult e)
        {
            var entity = this.mapper.Map<ExamResult>(e);

            service.Update(entity);
        }
        [HttpDelete]
        public void delete(ExamResult e)
        {
            service.Delete(e);
        }
    }
}
