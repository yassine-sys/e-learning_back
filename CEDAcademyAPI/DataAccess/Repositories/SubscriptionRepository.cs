using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class SubscriptionRepository<Subscription> : ISubscriptionRepository<Subscription> where Subscription : class
    {
        readonly ApplicationContext db;

        public SubscriptionRepository(ApplicationContext context)
        {
            db = context;
        }
        public IQueryable<Subscription> GetSubscriptions()
        {
            return db.Subscriptions;
        }
        public Subscription GetSubscription(int idSubscription)
        {
            Subscription subscription = db.Subscriptions.Find(idSubscription);
            if (subscription == null)
            {
                return null;
            }
            return subscription;
        }
        public Subscription SubscriptionByCourseidUserid(string idC, string idU)
        {
            var query = db.Subscriptions.Where(x => x.CourseID == idC && x.userId == idU);
            var subscription = query.FirstOrDefault<Subscription>();
            if (subscription != null)
            {
                return null;

            }
            return subscription;
        }
        public IQueryable<Subscription> SubscriptionbyUserId(string UserId)
        {
            var query = db.Subscriptions.Where(x => x.userId == UserId);
            var subscriptions = query.AsQueryable<Subscription>();
            return subscriptions;
        }
        public IQueryable<Subscription> SubscriptionbyCourseID(string CourseID)
        {
            var query = db.Subscriptions.Where(x => x.CourseID == CourseID);
            var subscriptions = query.AsQueryable<Subscription>();
            return subscriptions;
        }
        public void PostSubscription(Subscription subscription)
        {
            db.Subscriptions.Add(subscription);
            db.SaveChanges();            
        }
        public void DeleteSubscription(int idSubscription)
        {
            Subscription subscription = db.Subscriptions.Find(idSubscription);
            db.Subscriptions.Remove(subscription);
            db.SaveChanges();
        }





    }
}
