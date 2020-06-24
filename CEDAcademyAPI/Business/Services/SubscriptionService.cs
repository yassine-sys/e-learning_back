using Business.IServices;
using DataAccess.Infrastructure;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
   public class SubscriptionService : ISubscriptionService
    {
        readonly CEDAcademyDbContext db;
        public SubscriptionService(CEDAcademyDbContext context)
        {
            db = context;
        }
        public IQueryable<Subscription> SubscriptionbyUserId(string UserId)
        {
            var query = db.Subscriptions.Where(x => x.CreatedBy == UserId);
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
