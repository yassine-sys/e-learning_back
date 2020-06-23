using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class QuizRepository<Quiz> : IQuizRepository<Quiz> where Quiz: class
    {
        private ApplicationContext context;
        public QuizRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Quiz> GetQuizs()
        {
            return context.Quizs.ToList();
        }
        public Quiz GetQuizByID(int QuizID)
        {
            return context.Quizs.Find(QuizID);
        }

        public void InsertQuiz(Quiz quiz)
        {
            context.Quizs.Add(quiz);
        }

        public void DeleteQuiz(int QuizID)
        {
            Quiz quiz = context.Quizs.Find(QuizID);
            context.Quizs.Remove(quiz);
        }

        public void UpdateCustomer(Quiz quiz)
        {
            context.Entry(quiz).State = EntityState.Modified;
        }
    }
}
