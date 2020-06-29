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
    public class ExamService : IExamService
    {
        private IExamRepository repo;

        public ExamService(IExamRepository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Question> GetQuestionByExamID(int ExamID)
        {
            return context.Exams.Where(x => x.Question.Exams.Any(c => c.Id == ExamID));
        }
    }
}
