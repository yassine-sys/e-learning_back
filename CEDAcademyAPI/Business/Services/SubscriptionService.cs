using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
   public class SubscriptionService : ServiceBase<Subscription>, ISubscriptionService
    {
        private readonly ISubscriptionRepository repo;

        public SubscriptionService(ISubscriptionRepository repo)
             : base((RepositoryBase<Subscription>)repo)
        {
            this.repo = repo;
        }
        public IEnumerable<Subscription> GetSubscriptionbyUserId(string UserId)
        {
           return repo.GetAll().Where(x => x.CreatedBy == UserId).AsQueryable<Subscription>();
        }
        public IEnumerable<Subscription> GetSubscriptionbyCourseId(string CourseId)
        {
            return repo.GetAll().Where(x => x.CourseID == CourseId).AsQueryable<Subscription>();
        }
        public IEnumerable<Subscription> GetSubscriptionbyCourseIdUserId(string CourseId,string UserId)
        {
            return repo.GetAll().Where(x => x.CourseID==CourseId && x.CreatedBy == UserId).AsQueryable<Subscription>();
        }
        public int CountUsersbyCourseID(string CourseID)
        {
            var query = repo.GetAll().Where(x => x.CourseID == CourseID);
            var res = query.Count();
            return res;
        }
    }
}
