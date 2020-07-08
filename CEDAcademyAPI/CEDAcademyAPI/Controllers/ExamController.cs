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
    [RoutePrefix("api/exam")]
    public class ExamController : ApiController
    {
        private IExamService service;
        private readonly IMapper mapper;

        public ExamController(IExamService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<ExamDTO> GetExams()
        {
            var entity= service.GetAll();
            return mapper.Map<IEnumerable<ExamDTO>>(entity);
        }
        [HttpGet]
        [Route("{id}")]
        public ExamDTO GetExamById(int id)
        {
            var entity = service.GetById(id);
            return mapper.Map<ExamDTO>(entity);


        }
        [HttpGet]
        [Route("QuestionByExam/{ExamId}")]
        public IEnumerable<QuestionDTO> GetQuestionByExamID(int ExamId)
        {
            var entity = service.GetQuestionByExamID(ExamId);
            return mapper.Map<IEnumerable<QuestionDTO>>(entity);


        }
        [HttpPost]
        public void add(Exam e)
        {
            var entity = this.mapper.Map<Exam>(e);

            service.Add(entity);
        }
        [HttpPut]
        public void update(Exam e)
        {
            var entity = this.mapper.Map<Exam>(e);

            service.Update(entity);
        }
        [HttpDelete]
        public void delete(Exam e)
        {
            service.Delete(e);
        }
    }
}
