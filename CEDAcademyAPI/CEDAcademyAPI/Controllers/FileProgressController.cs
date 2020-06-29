using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class FileProgressController : ApiController
    {
        private IFileProgressService service;

        public FileProgressController(IFileProgressService service)
        {
            this.service = service;
        }
    }
}
