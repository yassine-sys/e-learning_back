using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IRepositories;

namespace DataAccess.Repositories
{
    public class ParagraphProgressRepository<ParagraphProgress> : IParagraphProgressRepository<ParagraphProgress> where ParagraphProgress : class
    {
        readonly ApplicationContext db;

        public ParagraphProgressRepository(ApplicationContext context)
        {
            db = context;
        }
        public IQueryable<ParagraphProgress> GetParagraphProgresses()
        {
            return db.ParagraphProgresses;
        }
        public ParagraphProgress GetParagraphProgress(int paragraphId)
        {
            ParagraphProgress paragraphProgress = db.ParagraphProgresses.Find(paragraphId);
            if (paragraphProgress == null)
            {
                return null;
            }
            return paragraphProgress;
        }
        public List<ParagraphProgress> PragraphProgressBySectionID(int Sectionid)
        {
            var query = db.ParagraphProgresses.Where(x => x.SectionID == Sectionid).ToList();
           // var paragraphs = query.AsQueryable<ParagraphProgress>();

            return query;
        }
        public void PostParagraphProgress(ParagraphProgress paragraphProgress)
        {
            db.ParagraphProgresses.Add(paragraphProgress);
            db.SaveChanges();
        }
        public void DeleteParagraphProgress(int idPP)
        {
            ParagraphProgress paragraphProgress = db.ParagraphProgresses.Find(idPP);
            db.ParagraphProgresses.Remove(paragraphProgress);
            db.SaveChangesAsync();
        }




    }
}
