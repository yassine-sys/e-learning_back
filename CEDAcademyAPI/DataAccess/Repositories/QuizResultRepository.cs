using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class QuizResultRepository <QuizResult>: IQuizResultRepository<QuizResult> where QuizResult:class
    {
        private ApplicationContext context;
        public QuizResultRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<QuizResult> GetQuizResults()
        {
            return context.QuizResults.ToList();
        }
        public QuizResult GetQuizResultByID(int ResID)
        {
            return context.QuizResults.Find(ResID);
        }

        public void InsertQuizResult(QuizResult quizResult)
        {
            context.QuizResults.Add(quizResult);
        }

        public void DeleteQuizResult(int ResID)
        {
            QuizResult quizResult = context.QuizResults.Find(ResID);
            context.QuizResults.Remove(quizResult);
        }

        public void UpdateCustomer(QuizResult quizResult)
        {
            context.Entry(quizResult).State = EntityState.Modified;
        }
    }
}
