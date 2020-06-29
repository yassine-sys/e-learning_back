using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class SubscriptionController : ApiController
    {
        private ISubscriptionService service;

        public SubscriptionController(ISubscriptionService service)
        {
            this.service = service;
        }
    }
}
