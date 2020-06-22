using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface IRatingRepository<Rating> where Rating : class
    {
        void PostRating(Rating rating, string id);
        void PutRating(Rating r);
        IQueryable<Rating> GetRatings();

    }
}
