using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class QuizService : ServiceBase<Quiz>, IQuizService
    {
        private IQuizRepository repo;
        private IQuestionRepository questionRepository;

        public QuizService(IQuizRepository repo, IQuestionRepository questionRepository)
            : base((RepositoryBase<Quiz>)repo)
        {
            this.repo = repo;
            this.questionRepository = questionRepository;
        }
        public IEnumerable<Question> GetQuestionByQuizID(int QuizID)
        {
            // return context.Questions.Where(x => x.Quizzes.Any(c => c.Id == QuizID));
            return questionRepository.GetAll().Where(x => x.Quizzes.Any(c => c.Id == QuizID));

        }
    }
}
