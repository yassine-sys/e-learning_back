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
        private readonly IExamRepository repo;
        private readonly IQuestionRepository questionRepository;
        public ExamService(IExamRepository repo, IQuestionRepository questionRepository)
        : base((RepositoryBase<Exam>)repo)
        {
            this.repo = repo;
            this.questionRepository = questionRepository;
        }
        public IEnumerable<Question> GetQuestionByExamID(int ExamID)
        {
            //return context.Questions.Where(x => x.Exams.Any(c => c.Id == ExamID));
            return questionRepository.GetAll().Where(x => x.ExamID== ExamID);
        }
        public IEnumerable<Exam> GetExamsByCourse(int CourseID)
        {
            return repo.GetAll().Where(x => x.CourseID == CourseID);
        }
    }
}
