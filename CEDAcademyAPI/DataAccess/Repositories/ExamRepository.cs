using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Repositories
{
   public class ExamRepository : RepositoryBase<Exam>, IExamRepository
    {
        public ExamRepository(CEDAcademyDbContext db)
            : base(db)
        {
        }

    }
}
