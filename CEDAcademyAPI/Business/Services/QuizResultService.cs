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
    public class QuizResultService: IQuizResultService
    {
        private IQuizResultRepository repo;

        public QuizResultService(IQuizResultRepository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Quiz> GetQuizResultsByQuizID(int QuizID)
        {
            return context.Quizzes.Where(x => x.QuizResults.Quizs.Any(c => c.Id == QuizID));

        }

    }
}
