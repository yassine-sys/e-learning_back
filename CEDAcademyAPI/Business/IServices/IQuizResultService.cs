using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    interface IQuizResultService<Quiz> where Quiz:class
    {
        IEnumerable<Quiz> GetQuizResultsByQuizID(int QuizID);

    }
}
