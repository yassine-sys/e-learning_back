using DataAccess.Infrastructure;
using Entities.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public  interface ICertificateRepository : IRepositoryBase<CEDAcademyDbContext, Certificate>
    {
    }
}
