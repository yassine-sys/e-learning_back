using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ExamService : ServiceBase<Exam>, IExamService
    {
        private IExamRepository repo;

        public ExamService(IExamRepository repo)
        : base((RepositoryBase<Exam>)repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Question> GetQuestionByExamID(int ExamID)
        {
            return context.Exams.Where(x => x.Question.Exams.Any(c => c.Id == ExamID));
        }
    }
}
