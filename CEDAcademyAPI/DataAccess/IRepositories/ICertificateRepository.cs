using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    interface ICertificateRepository<Certificate> where Certificate:class
    {
        IEnumerable<Certificate> GetCertificates();
        Certificate GetCertificateByID(int CertifID);
        void InsertCertificate(Certificate certificate);
        void DeleteCertificate(int CertifID);
        void UpdateCertificate(Certificate certificate);
    }
}
