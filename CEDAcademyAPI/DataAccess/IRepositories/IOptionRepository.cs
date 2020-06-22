using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    interface IOptionRepository<Option> where Option:class
    {
        IEnumerable<Option> GetOptions();
        Option GetOptionByID(int OpID);
        void InsertOption(Option option);
        void DeleteOption(int OpID);
        void UpdateOption(Option option);
    }
}
