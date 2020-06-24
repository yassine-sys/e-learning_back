using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    class ExamService<Question> : IExamService<Question> where Question:class
    {
        private ApplicationContext context;
        public ExamService(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Question> GetQuestionByExamID(int ExamID)
        {
            return context.Exams.Where(x => x.Question.Exams.Any(c => c.ExamID == ExamID));
        }
    }
}
