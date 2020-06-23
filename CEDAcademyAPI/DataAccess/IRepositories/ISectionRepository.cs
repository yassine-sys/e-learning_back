using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface ISectionRepository<Section> where Section : class
    {
        IQueryable<Section> SectionbyChapterID(int ChapterID);
        Section GetSection(int idSection);
    }
}
