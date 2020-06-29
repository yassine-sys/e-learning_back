using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public class QuizRepository : RepositoryBase<CEDAcademyDbContext, Quiz>, IQuizRepository
    {
        public QuizRepository(CEDAcademyDbContext db)
            : base(db)
        {
        }

    }
}
