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
    public class RatingController : ApiController
    {
        private IRatingService service;

        public RatingController(IRatingService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("api/GetCurrentRating/{idCourse}/{idUser}")]
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
        [Route("api/RatingByUserId/{idCourse}/{idUser}")]
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
        [Route("api/RatingAvg/{idCourse}")]
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
        [Route("api/RatingCourseOrder")]
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
        [Route("api/RatingSommeOrder")]
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
        [Route("api/AddRating/{id}")]
        public HttpResponseMessage AddRating(Rating rating)
        {
            service.Add(rating);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpPut]
        [Route("api/PutRating")]
        public IHttpActionResult UpdateRating(Rating rating)
        {
            service.Update(rating);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
