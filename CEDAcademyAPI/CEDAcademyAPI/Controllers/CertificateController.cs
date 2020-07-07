using Business.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    [RoutePrefix("api/certificate")]
    public class CertificateController : ApiController
    {

        private ICertificateService service;

        public CertificateController(ICertificateService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<Certificate> GetCertificates()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public Certificate GetCertificatesById(int id)
        {
            return service.GetById(id);
        }
        [HttpPost]
        public void add(Certificate c)
        {
            service.Add(c);
        }
        [HttpPut]
        public void update(Certificate c)
        {
            service.Update(c);
        }
        [HttpDelete]
        public void delete(Certificate c)
        {
            service.Delete(c);
        }
    }
}
