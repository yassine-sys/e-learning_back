using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class RatingService : ServiceBase<Rating>, IRatingService
    {
        private readonly IRatingRepository repo;

        public RatingService(IRatingRepository repo)
            : base((RepositoryBase<Rating>)repo)
        {
            this.repo = repo;
        }
        public IEnumerable<int> GetCourseScoreByUserId(int CourseId, string IdUser)
        {
            return repo.GetAll().Where(x => x.CourseID == CourseId && x.CreatedBy == IdUser).Select(x => x.Score);
           
        }
        public IEnumerable<Rating> GetCourseRatingByUserId(int CourseId, string IdUser)
        {
            return repo.GetAll().Where(x => x.CourseID == CourseId && x.CreatedBy == IdUser);

        }
        public int GetCourseRatingAvg(int CourseId)
        {
            var query= repo.GetAll().Where(x => x.CourseID == CourseId);
            var RatingAvg = query.Sum(x=>x.Score) / query.Count();
            if (RatingAvg == 0)
            {
                return 0;
            }
            else
            {
                return RatingAvg;
            }
        }
        public List<String> GetCourseTitleByRatingOrder()
        {/*
            var query = repo.GetAll();
            int RatingAvg = query.Sum(x => x.Score) / query.Count();
            var query1 = query.OrderByDescending( ).Select(x => x.Course.title).Take(5).ToList();
           
            if (query == null)
            {
                return null;
            }
            else
            {
                return query1;
            }*/
            return null;
        }
        public List<Rating> RatingSommeOrder()
        {
            /* var query = repo.GetAll();
             int RatingAvg = query.Sum(x => x.Score) / query.Count();
             var query2 = query.OrderByDescending(x => x.Score.). Select(query.Sum(x => x.Score) / query.Count());
             var query1= (from st in db.Ratings
                          group st by st.Course.title into g
                          orderby (g.Sum(x => x.Score) / g.Count()) descending
                          select new
                          {
                            CourseSomme = (g.Sum(x => x.Score) / g.Count())
                          }).Take(5).ToList();
             if (query == null)
             {
                 return null;
             }
             else
             {
                 return query;
             }*/
            return null;

        }

    }
}
