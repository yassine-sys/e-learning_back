using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Infrastructure;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class SubscriptionRepository : RepositoryBase<Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(CEDAcademyDbContext db)
            : base(db)
        {
        }

    }
}
