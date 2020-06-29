using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class FileController : ApiController
    {
        private IFileService service;

        public FileController(IFileService service)
        {
            this.service = service;
        }
    }
}
