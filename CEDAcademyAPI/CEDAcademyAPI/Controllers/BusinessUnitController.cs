using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class BusinessUnitController : ApiController
    {
        private IBusinessUnitService service;

        public BusinessUnitController(IBusinessUnitService service)
        {
            this.service = service;
        }
    }
}
