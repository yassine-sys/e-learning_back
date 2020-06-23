using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
   public class SubscriptionService : ISubscriptionService
    {
        readonly ApplicationDbContext db;
        public SubscriptionService(ApplicationDbContext context)
        {
            db = context;
        }
        public IQueryable<Subscription> SubscriptionbyUserId(string UserId)
        {
            var query = db.Subscriptions.Where(x => x.userId == UserId);
            var subscriptions = query.AsQueryable<Subscription>();
            return subscriptions;
        }
        public int CountUsersbyCourseID(string CourseID)
        {
            var query = db.Subscriptions.Where(x => x.CourseID == CourseID);
            var res = query.Count();
            return res;
        }
    }
}
