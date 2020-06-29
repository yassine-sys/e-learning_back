using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class ExamController : ApiController
    {
        private IExamService service;

        public ExamController(IExamService service)
        {
            this.service = service;
        }
    }
}
