using Business.IServices;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CertificateService : ServiceBase<Certificate>, ICertificateService
    {
        private readonly ICertificateRepository repo;

        public CertificateService(ICertificateRepository repo)
         : base((RepositoryBase<Certificate>)repo)

        {
            this.repo = repo;
        }
    }
}
