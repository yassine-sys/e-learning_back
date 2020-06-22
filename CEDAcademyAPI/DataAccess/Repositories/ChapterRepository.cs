using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IRepositories;


namespace DataAccess.Repositories
{
    public class ChapterRepository<Chapter> : IChapterRepository<Chapter> where Chapter : class
    {
        readonly ApplicationContext db;

        public ChapterRepository(ApplicationContext context)
        {
            db = context;
        }
        public IEnumerable<Chapter> GetChapters()
        {
            return db.Chapters.ToList();
        }
        public Chapter GetChapter(int ChapterId)

        {
            return db.Chapters.Find(ChapterId);
        }
        public IQueryable<Chapter> ChapterbyCourseID(int CourseId)

        {
            var query = from C in db.Chapters
                        where C.CourseID == CourseId
                        select C;
            var chapters = query.AsQueryable<Chapter>();
            return chapters;
        }
        public void PostChapter(Chapter chapter)
        {
            db.Chapters.Add(chapter);
            db.SaveChanges();
        }
        public void DeleteChapter(int ChapterId)
        {
            Chapter chapter = db.Chapters.Find(ChapterId);
            db.Chapters.Remove(chapter);
            db.SaveChanges();
        }

    }
}
