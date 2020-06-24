using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    interface IQuestionService<Option> where Option:class
    {
        IEnumerable<Option> GetOptionByQuestionID(int QuesID);

    }
}
