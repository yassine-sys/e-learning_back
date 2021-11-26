using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface IQuestionService : IServiceBase<Question>
    {
        IEnumerable<Option> GetOptionByQuestionID(int QuesID);
        IEnumerable<Question> GetQuestionsByQuizID(int QuizID);
        IEnumerable<Question> GetQuestionsByExamID(int ExamID);
    }
}
