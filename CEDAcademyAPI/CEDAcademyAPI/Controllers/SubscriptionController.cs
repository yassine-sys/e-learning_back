using Business.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    [RoutePrefix("api/subscription")]
    public class SubscriptionController : ApiController
    {
        private ISubscriptionService service;

        public SubscriptionController(ISubscriptionService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<Subscription> GetSubscriptions()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("{IdSubscription}")]
        public IHttpActionResult GetSubscription(int IdSubscription)
        {
            var subscription = service.GetById(IdSubscription);
            return Ok(subscription);
        }
        [HttpPut]
        public IHttpActionResult UpdateSubscription(Subscription subscription)
        {
            service.Update(subscription);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpGet]
        [Route("{CourseId}/{UserId}")]
        public IHttpActionResult SubscriptionByCourseIdUserId(string CourseId, string UserId)
        {
            var subscription = service.GetSubscriptionbyCourseIdUserId(CourseId,UserId);
            return Ok(subscription);
        }
        [HttpGet]
        [Route("{UserId}")]
        public IHttpActionResult SubscriptionbyUserId(string UserId)
        {
            var subscription = service.GetSubscriptionbyUserId(UserId);
            return Ok(subscription);
        }
        [HttpGet]
        [Route("course/{CourseId}")]
        public IHttpActionResult SubscriptionbyCourseID(string CourseId)
        {
            var subscription = service.GetSubscriptionbyCourseId(CourseId);
            return Ok(subscription);
        }
        [HttpGet]
        [Route("Count/{UserId}")]
        public IHttpActionResult CountUsersbyCourseID(string UserId)
        {
            var NbreUser = service.CountUsersbyCourseID(UserId);
            return Ok(NbreUser);
        }
        [HttpPost]
        public HttpResponseMessage AddSubscription(Subscription subscription)
        {
            service.Add(subscription);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpDelete]
        public IHttpActionResult DeleteSubscription(Subscription subscription)
        {
            service.Delete(subscription);
            return Ok(subscription);
        }

    }
}
