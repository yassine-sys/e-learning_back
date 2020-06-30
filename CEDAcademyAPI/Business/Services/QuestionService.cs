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
        private IQuestionRepository repo;

        public QuestionService(IQuestionRepository repo)
            : base((RepositoryBase<Question>)repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Option> GetOptionByQuestionID(int QuesID)
        {
            return context.Questions.Where(x => x.Option.Questions.Any(c => c.QuesID == QuesID));
        }
    }
}
