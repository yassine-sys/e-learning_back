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
    public class QuestionService : IQuestionService
    {
        private IQuestionRepository repo;

        public QuestionService(IQuestionRepository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Option> GetOptionByQuestionID(int QuesID)
        {
            return context.Questions.Where(x => x.Option.Questions.Any(c => c.QuesID == QuesID));
        }
    }
}
