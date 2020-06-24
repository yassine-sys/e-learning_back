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
    public class ExamService : IExamService
    {
        private CEDAcademyDbContext context;
        public ExamService(CEDAcademyDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Question> GetQuestionByExamID(int ExamID)
        {
            return context.Exams.Where(x => x.Question.Exams.Any(c => c.Id == ExamID));
        }
    }
}
