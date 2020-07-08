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
    [RoutePrefix("api/quizResult")]
    public class QuizResultController : ApiController
    {
        private IQuizResultService service;
        private readonly IMapper mapper;


        public QuizResultController(IQuizResultService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<QuizResultDTO> GetQuizResults()
        {
            var entity = service.GetAll();
            return mapper.Map<IEnumerable<QuizResultDTO>>(entity);

        }
        [HttpGet]
        [Route("{id}")]

        public QuizResultDTO GetQuizResultById(int id)
        {
            var entity = service.GetById(id);
            return mapper.Map<QuizResultDTO>(entity);


        }
        [HttpGet]
        [Route("quizresultbyquiz/{QuizId}")]
        public IEnumerable<QuizResultDTO> GetQuizResultsByQuizID(int QuizId)
        {
            var entity = service.GetQuizResultsByQuizID(QuizId);
            return mapper.Map<IEnumerable<QuizResultDTO>>(entity);

        }
        [HttpPost]
        public void add(QuizResultDTO q)
        {
            var entity = this.mapper.Map<QuizResult>(q);

            service.Add(entity);
        }
        [HttpPut]
        public void update(QuizResultDTO q)
        {
            var entity = this.mapper.Map<QuizResult>(q);

            service.Update(entity);
        }
        [HttpDelete]
        public void delete(QuizResult q)
        {
            service.Delete(q);
        }
    }
}
