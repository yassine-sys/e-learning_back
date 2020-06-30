using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Business.Services
{
    public class ParagraphProgressService : ServiceBase<ParagraphProgress>, IParagraphProgressService
    {
        private IParagraphProgressRepository repo;

        public ParagraphProgressService(IParagraphProgressRepository repo)
            : base((RepositoryBase<ParagraphProgress>)repo)
        {
            this.repo = repo;
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
        public IEnumerable<ParagraphProgress> GetParagraphProgressByCourseIdUserId(int CourseId, string UserId)
        {
            return repo.GetAll().Where(x => x.CourseID == CourseId && x.userId== UserId);
         
        }
        public IEnumerable<ParagraphProgress> GetParagraphProgressBySectionId(int SectionId)
        {
            return repo.GetAll().Where(x => x.SectionID == SectionId);

        }
    }
}
