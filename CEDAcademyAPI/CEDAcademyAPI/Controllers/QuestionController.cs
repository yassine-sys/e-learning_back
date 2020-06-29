using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class QuestionController : ApiController
    {
        private IQuestionService service;

        public QuestionController(IQuestionService service)
        {
            this.service = service;
        }
    }
}
