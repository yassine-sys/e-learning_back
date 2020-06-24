using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class RatingRepository : IRepositoryBase<CEDAcademyDbContext, Rating>, IRatingRepository
    {
        

    }
}
