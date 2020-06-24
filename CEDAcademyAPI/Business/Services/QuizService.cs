using Business.IServices;
using DataAccess.Infrastructure;
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
        private CEDAcademyDbContext context;
        public QuizService(CEDAcademyDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Question> GetQuestionByQuizID(int QuizID)
        {
            return context.Quizzes.Where(x => x.Questions.Quizs.Any(c => c.Id == QuizID));
        }
    }
}
