using Business.IServices;
using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class OptionService: IOptionService
    {

        private IOptionRepository repo;

        public OptionService(IOptionRepository repo)
        {
            this.repo = repo;
        }
    }
}
