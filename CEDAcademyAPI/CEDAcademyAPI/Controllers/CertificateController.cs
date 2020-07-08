using AutoMapper;
using Business.IServices;
using Entities.Models;
using Entities.ModelsDTO;
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
        private readonly IMapper mapper;


        public CertificateController(ICertificateService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<CertificateDTO> GetCertificates()
        {
            var entity= service.GetAll();
            return mapper.Map<IEnumerable<CertificateDTO>>(entity);
        }
        [HttpGet]
        [Route("{id}")]
        public CertificateDTO GetCertificatesById(int id)
        {
            var entity = service.GetById(id);
            return mapper.Map<CertificateDTO>(entity);



        }
        [HttpPost]
        public void add(CertificateDTO c)
        {
            var entity = this.mapper.Map<Certificate>(c);

            service.Add(entity);
        }
        [HttpPut]
        public void update(CertificateDTO c)
        {
            var entity = this.mapper.Map<Certificate>(c);

            service.Update(entity);
        }
        [HttpDelete]
        public void delete(Certificate c)
        {
            service.Delete(c);
        }
    }
}
