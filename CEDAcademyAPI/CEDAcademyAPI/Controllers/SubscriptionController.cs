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
    public class SubscriptionController : ApiController
    {
        private ISubscriptionService service;

        public SubscriptionController(ISubscriptionService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/Subscriptions")]
        public IEnumerable<Subscription> GetSubscriptions()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("api/Subscription/{id}")]
        public IHttpActionResult GetSubscription(int IdSubscription)
        {
            var subscription = service.GetById(IdSubscription);
            return Ok(subscription);
        }
        [HttpPut]
        [Route("api/Subscription")]
        public IHttpActionResult UpdateSubscription(Subscription subscription)
        {
            service.Update(subscription);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpGet]
        [Route("api/Subscriptions/{CourseId}/{UserId}")]
        public IHttpActionResult SubscriptionByCourseIdUserId(string CourseId, string UserId)
        {
            var subscription = service.GetSubscriptionbyCourseIdUserId(CourseId,UserId);
            return Ok(subscription);
        }
        [HttpGet]
        [Route("api/Subscriptions/User/{id}")]
        public IHttpActionResult SubscriptionbyUserId(string UserId)
        {
            var subscription = service.GetSubscriptionbyUserId(UserId);
            return Ok(subscription);
        }
        [HttpGet]
        [Route("api/Subscriptions/Course/{id}")]
        public IHttpActionResult SubscriptionbyCourseID(string CourseId)
        {
            var subscription = service.GetSubscriptionbyCourseId(CourseId);
            return Ok(subscription);
        }
        [HttpGet]
        [Route("api/CourseSubscriptions/Count/{id}")]
        public IHttpActionResult CountUsersbyCourseID(string UserId)
        {
            var NbreUser = service.CountUsersbyCourseID(UserId);
            return Ok(NbreUser);
        }
        [HttpPost]
        [Route("api/Subscriptions")]
        public HttpResponseMessage AddSubscription(Subscription subscription)
        {
            service.Add(subscription);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpDelete]
        [Route("api/Subscription")]
        public IHttpActionResult DeleteSubscription(Subscription subscription)
        {
            service.Delete(subscription);
            return Ok(subscription);
        }

    }
}
