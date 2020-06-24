using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    class QuizResultService<Quiz> : IQuizResultService<Quiz> where Quiz : class
    {
        private ApplicationContext context;
        public QuizResultService(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Quiz> GetQuizResultsByQuizID(int QuizID)
        {
            return context.Quizs.Where(x => x.QuizResult.Quizs.Any(c => c.QuizID == QuizID));

        }

    }
}
