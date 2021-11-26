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
    [RoutePrefix("api/question")]
    public class QuestionController : ApiController
    {
        private IQuestionService service;
        private readonly IMapper mapper;
        private IQuizService quizService;
        private IExamService ExamService;


        public QuestionController(IQuestionService service, IExamService ExamService, IMapper mapper, IQuizService quizService)
        {
            this.service = service;
            this.mapper = mapper;
            this.quizService = quizService;
            this.ExamService = ExamService;
        }

        [HttpPost]
        [Route("{id}")]

        public void affect(Question question, int id)
        {
            question.Quizzes = quizService.GetById(id);
            service.Add(question);
            quizService.GetById(id).Questions.Add(question);



        }

        [HttpPost]
        [Route("exam/{id}")]

        public void affecter(Question question, int id)
        {
            question.Exams = ExamService.GetById(id);
            service.Add(question);
            ExamService.GetById(id).Questions.Add(question);



        }
        [HttpGet]
        public IEnumerable<QuestionDTO> GetQuestions()
        {
            var entity = service.GetAll();
            return mapper.Map<IEnumerable<QuestionDTO>>(entity);

        }
        [HttpGet]
        [Route("{id}")]
        public QuestionDTO GetQuestionById(int id)
        {
            var entity = service.GetById(id);
            return mapper.Map<QuestionDTO>(entity);

        }
        [HttpGet]
        [Route("optionbyquestions/{QuesId}")]
        public IEnumerable<OptionDTO> GetOptionByQuestionID(int QuesId)
        {
            var entity = service.GetOptionByQuestionID(QuesId);
            return mapper.Map<IEnumerable<OptionDTO>>(entity);
        }
        [HttpGet]
        [Route("GetQuestionsByQuiz/{QuizID}")]
        public IEnumerable<Question> GetQuestionsByQuizID(int QuizID)
        {
            return service.GetQuestionsByQuizID(QuizID);
        }
        [HttpGet]
        [Route("GetQuestionsByExam/{ExamID}")]
        public IEnumerable<Question> GetQuestionsByExamID(int ExamID)
        {
            return service.GetQuestionsByExamID(ExamID);
        }
        [HttpPost]
        public void add(QuestionDTO q)
        {
            var entity = this.mapper.Map<Question>(q);

            service.Add(entity);
        }
        [HttpPut]
        public void update(QuestionDTO q)
        {
            var entity = this.mapper.Map<Question>(q);

            service.Update(entity);
        }
        [HttpDelete]
        public void delete(Question q)
        {
            service.Delete(q);
        }
        [HttpDelete]
        [Route("{id}")]

        public void remove(int id)
        {
            service.Remove(id);
        }

    }
}
