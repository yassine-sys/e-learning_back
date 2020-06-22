using DataAccess.IRepositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class AnswerRepository<Answer>:IAnswerRepository<Answer> where Answer:class
    {
        private ApplicationContext context;
        public AnswerRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Answer> GetAnswers()
        {
            return context.Answers.ToList();
        }
        public Answer GetAnswerByID(int AnsID)
        {
            return context.Answers.Find(AnsID);
        }

        public void InsertAnswer(Answer answer)
        {
            context.Answers.Add(answer);
        }

        public void DeleteAnswer(int AnsID)
        {
            Answer answer = context.Answers.Find(AnsID);
            context.Answers.Remove(answer);
        }

        public void UpdateAnswer(Answer answer)
        {
            context.Entry(answer).State = EntityState.Modified;
        }

       
    }
}
