using Business.IServices;
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
    }
}
