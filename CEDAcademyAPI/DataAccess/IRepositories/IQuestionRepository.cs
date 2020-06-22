using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    interface IQuestionRepository<Question> where Question:class
    {
        IEnumerable<Question> GetQuestions();
        Question GetQuestionByID(int QuesID);
        void InsertQuestion(Question question);
        void DeleteQuestion(int QuesID);
        void UpdateQuestion(Question question);
    }
}
