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
    [RoutePrefix("api/rating")]
    public class RatingController : ApiController
    {
        private readonly IRatingService service;
        private readonly IMapper mapper;

        public RatingController(IRatingService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
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
        public IEnumerable<RatingDTO> GetCourseRatingByUserId(int CourseId, string IdUser)
        {
            var query = service.GetCourseRatingByUserId(CourseId, IdUser);
            if (query == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<IEnumerable<RatingDTO>>(query);
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
        public void AddRating(RatingDTO rating)
        {
            var r = this.mapper.Map<Rating>(rating);
            service.Add(r);
        }

        [HttpPut]
        public void UpdateRating(RatingDTO rating)
        {
            var r = this.mapper.Map<Rating>(rating);
            service.Update(r);
        }
    }
}
