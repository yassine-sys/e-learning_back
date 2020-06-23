using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    class ExamResultService<Exam> : IExamResultService<Exam> where Exam:class
    {
        private ApplicationContext context;
        public ExamResultService(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Exam> GetExamResultsByExamID(int ExamID)
        {
            return context.Exams.Where(x => x.ExamResult.Exams.Any(c=>c.ExamID== ExamID));
        }
        public IEnumerable<Exam> GetQuestionByExamID(int ExamID)
        {
            return context.Exams.Where(x => x.Question.Exams.Any(c => c.ExamID == ExamID));
        }

    }
}
