using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class OptionRepository<Option>:IOptionRepository<Option> where Option:class
    {
        private ApplicationContext context;
        public OptionRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Option> GetOptions()
        {
            return context.Options.ToList();
        }
        public Option GetOptionByID(int OpID)
        {
            return context.Options.Find(OpID);
        }

        public void InsertOption(Option option)
        {
            context.Options.Add(option);
        }

        public void DeleteOption(int OpID)
        {
            Option option = context.Options.Find(OpID);
            context.Options.Remove(option);
        }

        public void UpdateOption(Option option)
        {
            context.Entry(option).State = EntityState.Modified;
        }
    }
}
