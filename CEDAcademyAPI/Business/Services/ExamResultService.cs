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
    public class ExamResultService : ServiceBase<ExamResult> , IExamResultService
    {
        private IExamResultRepository repo;
        private IExamRepository examRepository;
        //private IQuestionRepository questionRepository;
        public ExamResultService(IExamResultRepository repo, IExamRepository examRepository)
             : base((RepositoryBase<ExamResult>)repo)
        {
            this.repo = repo;
            this.examRepository = examRepository;
        }
        public IEnumerable<Exam> GetExamResultsByExamID(int ExamID)
        {
            return examRepository.GetAll().Where(x => x.ExamResults.Any(c => c.Id == ExamID));
        }
        //public IEnumerable<Question> GetQuestionByExamID(int ExamID)
        //{
        //    // return context.Exams.Where(x => x.Questions.Any(c => c.Id == ExamID));
        //    return questionRepository.GetAll().Where(x => x.Exams.Any(c => c.Id == ExamID));
        //}

    }
}
