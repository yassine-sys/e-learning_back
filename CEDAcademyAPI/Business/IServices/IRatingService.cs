using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface IRatingService
    {
        Rating GetCurrentRating(int idCourse, string idUser);
        Rating RatingByUserID(int idCourse, string idUser);
        int RatingAvg(int idCourse);
        List<Rating> RatingCourseOrder();
        List<Rating> RatingSommeOrder();

    }
}
