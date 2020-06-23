using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    class QuizService<Question> : IQuizService<Question> where Question : class
    {
        private ApplicationContext context;
        public QuizService(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Question> GetQuestionByQuizID(int QuizID)
        {
            return context.Quizs.Where(x => x.Question.Quizs.Any(c => c.QuizID == QuizID));
        }
    }
}
