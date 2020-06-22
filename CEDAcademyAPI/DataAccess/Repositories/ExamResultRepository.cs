using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class ExamResultRepository<ExamResult> : IExamResultRepository<ExamResult> where ExamResult:class
    {
        private ApplicationContext context;
        public ExamResultRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<ExamResult> GetExamResults()
        {
            return context.ExamResults.ToList();
        }
        public ExamResult GetExamResultByID(int ResID)
        {
            return context.ExamResults.Find(ResID);
        }

        public void InsertExamResult(ExamResult examResult)
        {
            context.ExamResults.Add(examResult);
        }

        public void DeleteExamResult(int ResID)
        {
            ExamResult examResult = context.ExamResults.Find(ResID);
            context.ExamResults.Remove(examResult);
        }

        public void UpdateExamResult(ExamResult examResult)
        {
            context.Entry(examResult).State = EntityState.Modified;
        }
    }
}
