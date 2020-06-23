using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    interface IQuizResultRepository<QuizResult> where QuizResult:class
    {
        IEnumerable<QuizResult> GetQuizResults();
        QuizResult GetQuizResultByID(int ResID);
        void InsertQuizResult(QuizResult quizResult);
        void DeleteQuizResult(int ResID);
        void UpdateQuizResult(QuizResult quizResult);
    }
}
