using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ParagraphService:IParagraphService
    {
        readonly ApplicationDbContext db;

        public ParagraphService(ApplicationDbContext context)
        {
            db = context;
        }

    }
}
