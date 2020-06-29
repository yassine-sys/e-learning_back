using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class QuizResultController : ApiController
    {
        private IQuizResultService service;

        public QuizResultController(IQuizResultService service)
        {
            this.service = service;
        }
    }
}
