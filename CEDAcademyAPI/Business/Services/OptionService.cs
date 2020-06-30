using Business.IServices;
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
    public class OptionService : ServiceBase<Option>, IOptionService
    {

        private IOptionRepository repo;

        public OptionService(IOptionRepository repo)
            : base((RepositoryBase<Option>)repo)
        {
            this.repo = repo;
        }
    }
}
