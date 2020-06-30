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
    public class CertificateController : ApiController
    {

        private ICertificateService service;

        public CertificateController(ICertificateService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/get_Certificate")]
        public IEnumerable<Certificate> GetCertificates()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("api/get_Certificate/{id}")]
        public Certificate GetCertificatesById(int id)
        {
            return service.GetById(id);
        }
        [HttpPost]
        [Route("api/add_Certificate")]
        public void add(Certificate c)
        {
            service.Add(c);
        }
        [HttpPut]
        [Route("api/update_Certificate")]
        public void update(Certificate c)
        {
            service.Update(c);
        }
        [HttpDelete]
        [Route("api/delete_Certificate")]
        public void delete(Certificate c)
        {
            service.Delete(c);
        }
    }
}
