using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IRepositories;

namespace DataAccess.Repositories
{
   public class ParagraphRepository<Paragraph> : IParagraphRepository<Paragraph> where Paragraph : class
    {
        readonly ApplicationContext db;

        public ParagraphRepository(ApplicationContext context)
        {
            db = context;
        }
        public IEnumerable<Paragraph> GetParagraphs()
        {
            return db.Paragraphs.ToList();
        }
        public IQueryable<Paragraph> ParagraphbySectionID(int SectionID)
        {
            var query = from P in db.Paragraphs
                        where P.SectionID == SectionID
                        select P;

            var paragraphs = query.AsQueryable<Paragraph>();
            return paragraphs;
        }
        public Paragraph GetParagraph(int id)
        {
            Paragraph paragraph =db.Paragraphs.FindAsync(id);
            if (paragraph == null)
            {
                return null;
            }
            return paragraph;
        }
        public void PostParagraph(Paragraph paragraph)
        {
            db.Paragraphs.Add(paragraph);
            db.SaveChanges();
        }
        public void DeleteParagraph(int ParagraphId)
        {
            Paragraph paragraph = db.Paragraphs.FindAsync(ParagraphId);
            db.Paragraphs.Remove(paragraph);
            db.SaveChanges();
        }

    }
}
