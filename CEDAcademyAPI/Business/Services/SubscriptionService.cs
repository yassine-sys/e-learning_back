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
        private ISubscriptionRepository repo;

        public SubscriptionService(ISubscriptionRepository repo)
             : base((RepositoryBase<Subscription>)repo)
        {
            this.repo = repo;
        }
        public IQueryable<Subscription> GetSubscriptionbyUserId(string UserId)
        {
           return repo.GetAll().Where(x => x.CreatedBy == UserId).AsQueryable<Subscription>();
        }
        public IQueryable<Subscription> GetSubscriptionbyCourseId(string CourseId)
        {
            return repo.GetAll().Where(x => x.CourseID == CourseId).AsQueryable<Subscription>();
        }
        public IQueryable<Subscription> GetSubscriptionbyCourseIdUserId(string CourseId,string UserId)
        {
            return repo.GetAll().Where(x => x.CourseID==CourseId && x.CreatedBy == UserId).AsQueryable<Subscription>();
        }
        public int CountUsersbyCourseID(string CourseID)
        {
            var query = repo.GetAll().Where(x => x.CourseID == CourseID);
            var res = query.Count();
            return res;
        }
        public IEnumerable<Subscription> GetSubscriptions()
        {
            throw new NotImplementedException();
        }
        public Subscription GetSubscriptionById(int id)
        {
            throw new NotImplementedException();
        }
        public void AddSubscription(Subscription s)
        {

        }
        public void UpdateSubscription(Subscription s)
        {

        }
        public void DeleteSubscription(Subscription s)
        {

        }
    }
}
