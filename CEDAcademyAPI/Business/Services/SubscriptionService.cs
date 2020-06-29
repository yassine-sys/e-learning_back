using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
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
        private ISubscriptionRepository repo;

        public SubscriptionService(ISubscriptionRepository repo)
        {
            this.repo = repo;
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
