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
        private ICourseService courseService;


        public QuizController(IQuizService service, ICourseService courseService, IMapper mapper)
        {
            this.service = service;
            this.courseService = courseService;
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
        [HttpGet]
        [Route("quizbycourse/{CourseID}")]

        public IEnumerable<QuizDTO> GetQuizByCourseID(int CourseID)
        {
            var entity = service.GetQuizByCourseID(CourseID);
            return mapper.Map<IEnumerable<QuizDTO>>(entity);

        }
        [HttpPost]
        public void add(QuizDTO q)
        {
            var entity = this.mapper.Map<Quiz>(q);

            service.Add(entity);
        }

        [HttpPost]
        [Route("{id}")]

        public void affect(Quiz quiz, int id)
        {
            quiz.Course = courseService.GetById(id);
            service.Add(quiz);
            courseService.GetById(id).Quizzes.Add(quiz);



        }
        [HttpPut]
        public void update(QuizDTO q)
        {
            var entity = this.mapper.Map<Quiz>(q);

            service.Update(entity);
        }
        [HttpDelete]
        [Route("{id}")]

        public void remove(int id)
        {
            service.Remove(id);
        }
    }
}
