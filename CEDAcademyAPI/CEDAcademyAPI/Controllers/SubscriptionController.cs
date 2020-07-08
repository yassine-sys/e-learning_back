using AutoMapper;
using Business.IServices;
using Entities.Models;
using Entities.ModelsDTO;
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
        private readonly ISubscriptionService service;
        private readonly IMapper mapper;

        public SubscriptionController(ISubscriptionService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<SubscriptionDTO> GetSubscriptions()
        {
            var x = service.GetAll();
            return mapper.Map<IEnumerable<SubscriptionDTO>>(x);
        }
        [HttpGet]
        [Route("{IdSubscription}")]
        public SubscriptionDTO GetSubscription(int IdSubscription)
        {
            var subscription = service.GetById(IdSubscription);
            return mapper.Map<SubscriptionDTO>(subscription);
        }
        [HttpPut]
        public void UpdateSubscription(SubscriptionDTO subscription)
        {
            var s = this.mapper.Map<Subscription>(subscription);
            service.Update(s);
        }
        [HttpGet]
        [Route("{CourseId}/{UserId}")]
        public IEnumerable<SubscriptionDTO> SubscriptionByCourseIdUserId(string CourseId, string UserId)
        {
            var subscription = service.GetSubscriptionbyCourseIdUserId(CourseId,UserId);
            return mapper.Map<IEnumerable<SubscriptionDTO>>(subscription);
        }
        [HttpGet]
        [Route("{UserId}")]
        public IEnumerable<SubscriptionDTO> SubscriptionbyUserId(string UserId)
        {
            var subscription = service.GetSubscriptionbyUserId(UserId);
            return mapper.Map<IEnumerable<SubscriptionDTO>>(subscription);
        }
        [HttpGet]
        [Route("course/{CourseId}")]
        public IEnumerable<SubscriptionDTO> SubscriptionbyCourseID(string CourseId)
        {
            var subscription = service.GetSubscriptionbyCourseId(CourseId);
            return mapper.Map<IEnumerable<SubscriptionDTO>>(subscription);
        }
        [HttpGet]
        [Route("Count/{UserId}")]
        public IHttpActionResult CountUsersbyCourseID(string UserId)
        {
            var NbreUser = service.CountUsersbyCourseID(UserId);
            return Ok(NbreUser);
        }
        [HttpPost]
        public void AddSubscription(Subscription subscription)
        {
            var s = this.mapper.Map<Subscription>(subscription);
            service.Add(s);
        }
        [HttpDelete]
        public IHttpActionResult DeleteSubscription(Subscription subscription)
        {
            service.Delete(subscription);
            return Ok(subscription);
        }

    }
}
