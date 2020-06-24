using Business.IServices;
using DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ParagraphService:IParagraphService
    {
        readonly CEDAcademyDbContext db;

        public ParagraphService(CEDAcademyDbContext context)
        {
            db = context;
        }

    }
}
