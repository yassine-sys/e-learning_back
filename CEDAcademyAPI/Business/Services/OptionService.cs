using Business.IServices;
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
    public class OptionService : ServiceBase<Option>, IOptionService
    {

        private IOptionRepository repo;
        private IQuestionRepository QuestionRepository;


        public OptionService(IOptionRepository repo, IQuestionRepository questionRepository)
            : base((RepositoryBase<Option>)repo)
        {
            this.repo = repo;
            this.QuestionRepository = questionRepository;
        }
        public IEnumerable<Question> GetOptionsByQuestionId(int QuesId)
        {
            return QuestionRepository.GetAll().Where(x => x.Options.Any(c => c.QuesId == QuesId));
        }
    }
}
