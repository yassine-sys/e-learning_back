using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    interface IAnswerRepository<Answer> where Answer:class
    {
        IEnumerable<Answer> GetAnswers();
        Answer GetAnswerByID(int AnsID);
        void InsertAnswer(Answer answer);
        void DeleteAnswer(int AnsID);
        void UpdateAnswer(Answer answer);
    }
}
