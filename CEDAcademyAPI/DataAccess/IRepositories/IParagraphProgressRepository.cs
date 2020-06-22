using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface IParagraphProgressRepository<ParagraphProgress> where ParagraphProgress : class
    {
        IQueryable<ParagraphProgress> GetParagraphProgresses();
        ParagraphProgress GetParagraphProgress(int paragraphId);
        List<ParagraphProgress> PragraphProgressBySectionID(int Sectionid);
        void PostParagraphProgress(ParagraphProgress paragraphProgress);
        void DeleteParagraphProgress(int idPP);
    }
}
