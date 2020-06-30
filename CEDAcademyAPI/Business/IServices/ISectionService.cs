using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface ISectionService : IServiceBase<Section>
    {
        IEnumerable<Section> GetSectionbyChapterId(int ChapterId);
    }
}
