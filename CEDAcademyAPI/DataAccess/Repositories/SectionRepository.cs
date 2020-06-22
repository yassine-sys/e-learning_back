using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IRepositories;

namespace DataAccess.Repositories
{
    public class SectionRepository<Section> : ISectionRepository<Section> where Section : class
    {
        readonly ApplicationContext db;

        public SectionRepository(ApplicationContext context)
        {
            db = context;
        }
        public IQueryable<Section> SectionbyChapterID(int ChapterID)
        {
            var query = from S in db.Sections
                        where S.ChapterID == ChapterID
                        select S;
            var sections = query.AsQueryable<Section>();
            return sections;
        }
        public Section GetSection(int idSection)
        {
            Section section = db.Sections.Find(idSection);
            if (section == null)
            {
                return null;
            }
            return section;
        }

    }
}
