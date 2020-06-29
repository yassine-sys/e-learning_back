using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ParagraphService:IParagraphService
    {
        private IParagraphRepository repo;

        public ParagraphService(IParagraphRepository repo)
        {
            this.repo = repo;
        }

    }
}
