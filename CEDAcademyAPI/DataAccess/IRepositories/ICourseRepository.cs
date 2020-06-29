using DataAccess.Infrastructure;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface ICourseRepository : IRepositoryBase<CEDAcademyDbContext, Course>
    {
    }
}
