using Business.IServices;
using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CertificateService : ICertificateService
    {
        private ICertificateRepository repo;

        public CertificateService(ICertificateRepository repo)
        {
            this.repo = repo;
        }
    }
}
