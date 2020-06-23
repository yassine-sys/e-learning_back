using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface IParagraphRepository<Paragraph> where Paragraph : class
    {
        IEnumerable<Paragraph> GetParagraphs();
        IQueryable<Paragraph> ParagraphbySectionID(int SectionID);
        Paragraph GetParagraph(int id);
        void PostParagraph(Paragraph paragraph);
        void DeleteParagraph(int ParagraphId);
    }
}
