using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class QuizService : IQuizService
    {
        private IQuizRepository repo;

        public QuizService(IQuizRepository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Question> GetQuestionByQuizID(int QuizID)
        {
            return context.Quizzes.Where(x => x.Questions.Quizs.Any(c => c.Id == QuizID));
        }
    }
}
