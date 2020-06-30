using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface IRatingService : IServiceBase<Rating>
    {
        IEnumerable<int> GetCourseScoreByUserId(int CourseId, string IdUser);
        IEnumerable<Rating> GetCourseRatingByUserId(int CourseId, string IdUser);
        int GetCourseRatingAvg(int CourseId);
        List<String> GetCourseTitleByRatingOrder();
        List<Rating> RatingSommeOrder();
    }
}
