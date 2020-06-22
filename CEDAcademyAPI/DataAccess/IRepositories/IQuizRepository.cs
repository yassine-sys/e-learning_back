using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    interface IQuizRepository<Quiz> where Quiz:class
    {
        IEnumerable<Quiz> GetQuizs();
        Quiz GetQuizByID(int QuizID);
        void InsertQuiz(Quiz quiz);
        void DeleteQuiz(int QuizID);
        void UpdateQuiz(Quiz quiz);
    }
}
