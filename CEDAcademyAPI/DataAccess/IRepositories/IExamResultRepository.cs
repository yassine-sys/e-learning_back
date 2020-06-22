using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    interface IExamResultRepository<ExamResult> where ExamResult:class
    {
        IEnumerable<ExamResult> GetExamResults();
        ExamResult GetExamResultByID(int ResID);
        void InsertExamResult(ExamResult examResult);
        void DeleteExamResult(int ResID);
        void UpdateExamResult(ExamResult examResult);
    }
}
