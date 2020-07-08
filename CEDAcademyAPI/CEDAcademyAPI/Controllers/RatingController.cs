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
    [RoutePrefix("api/rating")]
    public class RatingController : ApiController
    {
        private IRatingService service;

        public RatingController(IRatingService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("GetCurrentRating/{CourseId}/{IdUser}")]
        public IHttpActionResult GetCourseScoreByUserId(int CourseId, string IdUser)
        {
            var query = service.GetCourseScoreByUserId(CourseId, IdUser);
            if (query == null)
            {
                return null;
            }
            else
            {
                return Ok(query);
            }
        }
        [HttpGet]
        [Route("RatingByUserId/{CourseId}/{IdUser}")]
        public IHttpActionResult GetCourseRatingByUserId(int CourseId, string IdUser)
        {
            var query = service.GetCourseRatingByUserId(CourseId, IdUser);
            if (query == null)
            {
                return null;
            }
            else
            {
                return Ok(query);
            }
        }
        [HttpGet]
        [Route("Avg/{CourseId}")]
        public IHttpActionResult GetCourseRatingAvg(int CourseId)
        {
            var query = service.GetCourseRatingAvg(CourseId);
            if (query == 0)
            {
                return Ok(0);
            }
            else
            {
                return Ok(query);
            }
        }
        [HttpGet]
        [Route("RatingCourseOrder")]
        public IHttpActionResult GetCourseTitleByRatingOrder()
        {
            var query = service.GetCourseTitleByRatingOrder();
            if (query == null)
            {
                return null;
            }
            else
            {
                return Ok(query);
            }
        }
        [HttpGet]
        [Route("RatingSommeOrder")]
        public IHttpActionResult GetRatingSommeOrder()
        {
            var query = service.RatingSommeOrder();
            if (query == null)
            {
                return null;
            }
            else
            {
                return Ok(query);
            }
        }
        [HttpPost]
        public HttpResponseMessage AddRating(Rating rating)
        {
            service.Add(rating);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpPut]
        public IHttpActionResult UpdateRating(Rating rating)
        {
            service.Update(rating);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
