using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class QuestionRepository<Question>: IQuestionRepository<Question> where Question:class
    {
        private ApplicationContext context;
        public QuestionRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Customer> GetQuestions()
        {
            return context.Customers.ToList();
        }
        public Question GetQuestionByID(int QuesID)
        {
            return context.Questions.Find(QuesID);
        }

        public void InsertQuestion(Question question)
        {
            context.Questions.Add(question);
        }

        public void DeleteQuestion(int QuesID)
        {
            Question question = context.Questions.Find(QuesID);
            context.Questions.Remove(question);
        }

        public void UpdateQuestion(Question question)
        {
            context.Entry(question).State = EntityState.Modified;
        }
    }
}
