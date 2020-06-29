using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class ExamResultController : ApiController
    {
        private IExamResultService service;

        public ExamResultController(IExamResultService service)
        {
            this.service = service;
        }
    }
}
