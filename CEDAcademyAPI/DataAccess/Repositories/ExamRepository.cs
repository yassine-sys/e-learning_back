using DataAccess.IRepositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Repositories
{
    class ExamRepository<Exam> : IExamRepository<Exam> where Exam : class
    {
        private ApplicationContext context;
        public ExamRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Exam> GetExams()
        {
            
            return context.Exams.ToList();
        }
        public Exam GetExamByID(int ExamID)
        {
            return context.Exams.Find(ExamID);
        }

        public void InsertExam(Exam exam)
        {
            context.Exams.Add(exam);
        }

        public void DeleteExam(int ExamID)
        {
            Exam exam = context.Exams.Find(ExamID);
            context.Exams.Remove(exam);
        }

        public void UpdateCustomer(Exam exam)
        {
            context.Entry(exam).State = EntityState.Modified;
        }

      
    }
}
