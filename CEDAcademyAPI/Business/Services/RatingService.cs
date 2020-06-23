using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class RatingService : IRatingService
    {
        readonly ApplicationDbContext db;
        public RatingService(ApplicationDbContext context)
        {
            db = context;
        }
        public Rating GetCurrentRating(int idCourse, string idUser)
        {
            var query = from st in db.Ratings
                        where st.CourseID == idCourse && st.UserID == idUser
                        select st.Score;

            if (query == null)
            {
                return null;
            }
            else
            {
                return query;
            }
        }
        public Rating RatingByUserID(int idCourse, string idUser)
        {
            var query = from st in db.Ratings
                        where st.CourseID == idCourse && st.UserID == idUser
                        select st;

            if (query == null)
            {
                return null;
            }
            else
            {
                return query;
            }
        }
        public int RatingAvg(int idCourse)
        {
            var query = (from st in db.Ratings
                         where st.CourseID == idCourse
                         group st by 1 into g
                         select new
                         {
                             S = (g.Sum(x => x.Score)) / (g.Count())
                         }).ToList();
            if (query.Count() == 0)
            {
                return 0;
            }
            else
            {
                var x = Int32.Parse(query[0].ToString().Substring(6, 1));
                return x;
            }
        }
        public List<Rating> RatingCourseOrder()
        {
            var query = (from st in db.Ratings
                         group st by st.Course.title into g
                         orderby (g.Sum(x => x.Score) / g.Count()) descending
                         select new
                         {
                           CourseTitle = g.Key
                         }).Take(5).ToList();
            if (query == null)
            {
                return null;
            }
            else
            {
                return query;
            }
        }
        public List<Rating> RatingSommeOrder()
        {
            var query = (from st in db.Ratings
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
            }
        }


    }
}
