using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class CourseRepository : RepositoryBase<CEDAcademyDbContext, Course>, ICourseRepository
    {
        public CourseRepository(CEDAcademyDbContext db)
            : base(db)
        {
        }
    

    }
}
