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
        int paragraphProgressByCourseidUserid(int idC, string idU);
        IEnumerable<ParagraphProgress> GetParagraphProgresses();
        Chapter GetParagraphProgressById(int id);
    }
}
