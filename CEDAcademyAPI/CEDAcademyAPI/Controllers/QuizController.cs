using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class QuizController : ApiController
    {
        private IQuizService service;

        public QuizController(IQuizService service)
        {
            this.service = service;
        }
    }
}
