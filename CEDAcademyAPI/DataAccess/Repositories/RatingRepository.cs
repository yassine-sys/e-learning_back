using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IRepositories;

namespace DataAccess.Repositories
{
    public class RatingRepository<Rating> : IRatingRepository<Rating> where Rating : class
    {
        readonly ApplicationContext db;

        public RatingRepository(ApplicationContext context)
        {
            db = context;
        }
        public void PostRating(Rating rating, string id)
        {
                db.Ratings.Add(rating);
                db.SaveChanges();           
        }
        public void PutRating(Rating r)
        {
            db.Entry(r).State = EntityState.Modified;
            db.SaveChanges();
        }
        public IQueryable<Rating> GetRatings()
        {
            return db.Ratings;
        }

    }
}
