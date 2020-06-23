using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface ISubscriptionService
    {
        IQueryable<Subscription> SubscriptionbyUserId(string UserId);
        int CountUsersbyCourseID(string CourseID);
    }
}
