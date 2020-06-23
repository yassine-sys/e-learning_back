using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    interface IExamRepository<Exam> where Exam : class
    {
        IEnumerable<Exam> GetExams();
        Exam GetExamByID(int ExamID);
        void InsertExam(Exam exam);
        void DeleteExam(int ExamID);
        void UpdateExam(Exam exam);
    }
}
