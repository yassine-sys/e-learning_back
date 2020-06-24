using Business.IServices;
using DataAccess.Infrastructure;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Business.Services
{
    public class ParagraphProgressService : IParagraphProgressService
    {
        readonly CEDAcademyDbContext db;

        public ParagraphProgressService(CEDAcademyDbContext context)
        {
            db = context;
        }
        public int CountParagraphs(int CourseID)
        {
            var query = from c in db.Courses
                        join ch in db.Chapters on c.Id equals ch.CourseID
                        join s in db.Sections on ch.Id equals s.ChapterID
                        join p in db.Paragraphs on s.Id equals p.SectionID
                        select new
                        {
                            CourseID = c.Id,// or pc.ProdId
                            paragraphName = p.title,
                            // CatId = c.CatId // other assignments
                        };
            var courseid = query.Where(x => x.CourseID == CourseID);
            return courseid.Count();
        }
        public int paragraphProgressByCourseidUserid(int idC, string idU)
        {
            var query = db.ParagraphProgresses.Where(x => x.CourseID == idC && x.userId == idU);
            var paragraphProgresses = query.AsQueryable<ParagraphProgress>();
            return paragraphProgresses.Count();
        }

    }
}
