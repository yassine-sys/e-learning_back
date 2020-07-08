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
    [RoutePrefix("api/quiz")]
    public class QuizController : ApiController
    {
        private IQuizService service;
        private readonly IMapper mapper;


        public QuizController(IQuizService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<QuizDTO> GetQuizzes()
        {
            var entity = service.GetAll();
            return mapper.Map<IEnumerable<QuizDTO>>(entity);
        }
        [HttpGet]
        [Route("{id}")]
        public QuizDTO GetQuizById(int id)
        {
            var entity = service.GetById(id);
            return mapper.Map<QuizDTO>(entity);

        }
        [HttpGet]
        [Route("questionbyquiz/{QuizId}")]

        public IEnumerable<QuestionDTO> GetQuestionByQuizID(int QuizId)
        {
            var entity = service.GetQuestionByQuizID(QuizId);
            return mapper.Map<IEnumerable<QuestionDTO>>(entity);

        }
        [HttpPost]
        public void add(QuizDTO q)
        {
            var entity = this.mapper.Map<Quiz>(q);

            service.Add(entity);
        }
        [HttpPut]
        public void update(QuizDTO q)
        {
            var entity = this.mapper.Map<Quiz>(q);

            service.Update(entity);
        }
        [HttpDelete]
        public void delete(Quiz q)
        {
            service.Delete(q);
        }
    }
}
