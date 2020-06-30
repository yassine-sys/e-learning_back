using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.IServices
{
    public interface ISubscriptionService : IServiceBase<Subscription>
    {
        IQueryable<Subscription> GetSubscriptionbyUserId(string UserId);
        IQueryable<Subscription> GetSubscriptionbyCourseId(string CourseId);
        IQueryable<Subscription> GetSubscriptionbyCourseIdUserId(string CourseId, string UserId);
        int CountUsersbyCourseID(string CourseID);
    }
}
