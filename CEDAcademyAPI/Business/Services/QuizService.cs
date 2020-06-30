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

        public QuizService(IQuizRepository repo)
            : base((RepositoryBase<Quiz>)repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Question> GetQuestionByQuizID(int QuizID)
        {
            return context.Quizzes.Where(x => x.Questions.Quizs.Any(c => c.Id == QuizID));
        }
    }
}
