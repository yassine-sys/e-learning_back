using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface IOptionService : IServiceBase<Option>
    {
        IEnumerable<Option> GetOptionsByQuestionId(int QuesId);
    }
}
