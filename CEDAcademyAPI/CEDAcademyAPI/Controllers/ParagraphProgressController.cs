using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class ParagraphProgressController : ApiController
    {
        private IParagraphProgressService service;

        public ParagraphProgressController(IParagraphProgressService service)
        {
            this.service = service;
        }
    }
}
