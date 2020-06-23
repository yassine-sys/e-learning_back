using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class CertificateRepository<Certificate>: ICertificateRepository<Certificate> where Certificate:class
    {
        private ApplicationContext context;
        public CertificateRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Certificate> GetCertificates()
        {
            return context.Certificates.ToList();
        }
        public Certificate GetCertificateByID(int CertifID)
        {
            return context.Certificate.Find(CertifID);
        }

        public void InsertCertificate(Certificate certificate)
        {
            context.Certificates.Add(certificate);
        }

        public void DeleteCertificate(int CertifID)
        {
            Certificate certificate = context.Certificates.Find(CertifID);
            context.Certificates.Remove(certificate);
        }

        public void UpdateCertificate(Certificate certificate)
        {
            context.Entry(certificate).State = EntityState.Modified;
        }
    }
}
