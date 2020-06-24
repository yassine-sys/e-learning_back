using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    interface IExamResultService<Exam> where Exam:class
    {
        IEnumerable<Exam> GetExamResultsByExamID(int ExamID);
    }
}
