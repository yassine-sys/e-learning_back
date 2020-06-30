using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface IParagraphProgressService : IServiceBase<ParagraphProgress>
    {
        int CountParagraphs(int CourseID);
        IEnumerable<ParagraphProgress> GetParagraphProgressByCourseIdUserId(int CourseId, string UserId);
        IEnumerable<ParagraphProgress> GetParagraphProgressBySectionId(int SectionId);

    }
}
