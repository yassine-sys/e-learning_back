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
    public class ExamResultService: IExamResultService
    {
        private IExamResultRepository repo;

        public ExamResultService(IExamResultRepository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Exam> GetExamResultsByExamID(int ExamID)
        {
            return context.Exams.Where(x => x.ExamResult.Exams.Any(c=>c.Id== ExamID));
        }
        public IEnumerable<Exam> GetQuestionByExamID(int ExamID)
        {
            return context.Exams.Where(x => x.Question.Exams.Any(c => c.Id == ExamID));
        }

    }
}
