using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SectionService : ISectionService
    {
        readonly ApplicationDbContext db;
        public SectionService(ApplicationDbContext context)
        {
            db = context;
        }

    }
}
