using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    interface IQuizService<Question> where Question : class
    {
        IEnumerable<Question> GetQuestionByQuizID(int QuizID);

    }
}
