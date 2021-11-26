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
    public class QuestionService : ServiceBase<Question>, IQuestionService
    {
        private readonly IQuestionRepository repo;
        private readonly IOptionRepository optionRepository;
        public QuestionService(IQuestionRepository repo, IOptionRepository optionRepository)
            : base((RepositoryBase<Question>)repo)
        {
            this.repo = repo;
            this.optionRepository = optionRepository;
        }
        public IEnumerable<Option> GetOptionByQuestionID(int QuesID)
        {
            //return context.Options.Where(x => x.Questions.Any(c => c.Id == QuesID));
            return optionRepository.GetAll().Where(x => x.QuestionID == QuesID);

        }
        public IEnumerable<Question> GetQuestionsByQuizID(int QuizID)
        {
            return repo.GetAll().Where(x => x.QuizID == QuizID);
        }
        public IEnumerable<Question> GetQuestionsByExamID(int ExamID)
        {
            return repo.GetAll().Where(x => x.ExamID == ExamID);
        }
    }
}
