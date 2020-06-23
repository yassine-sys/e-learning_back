using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface ISubscriptionRepository<Subscription> where Subscription : class
    {
        IQueryable<Subscription> GetSubscriptions();
        Subscription GetSubscription(int idSubscription);
        Subscription SubscriptionByCourseidUserid(string idC, string idU);
        IQueryable<Subscription> SubscriptionbyUserId(string UserId);
        IQueryable<Subscription> SubscriptionbyCourseID(string CourseID);
        void PostSubscription(Subscription subscription);
        void DeleteSubscription(int idSubscription);

    }
}
