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
    public class QuizResultService : ServiceBase<QuizResult>, IQuizResultService
    {
        private IQuizResultRepository repo;
        private IQuizRepository quizRepository;
        public QuizResultService(IQuizResultRepository repo, IQuizRepository quizRepository)
            : base((RepositoryBase<QuizResult>)repo)
        {
            this.repo = repo;
            this.quizRepository = quizRepository;
        }
        public IEnumerable<QuizResult> GetQuizResultsByQuizID(int QuizID)
        {
            // return context.Quizzes.Where(x => x.QuizResults.Any(c => c.Id == QuizID));
            // return quizRepository.GetAll().Where(x => x.QuizResults.Any(c => c.QuizID == QuizID));
            return repo.GetAll().Where(x => x.QuizID == QuizID);
        }

    }
}
