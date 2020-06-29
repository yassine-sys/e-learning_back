using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class OptionController : ApiController
    {
        private IOptionService service;

        public OptionController(IOptionService service)
        {
            this.service = service;
        }
    }
}
