using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class ChapterController : ApiController
    {
        private IChapterService service;

        public ChapterController(IChapterService service)
        {
            this.service = service;
        }
    }
}
