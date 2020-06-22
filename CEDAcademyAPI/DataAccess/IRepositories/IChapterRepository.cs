using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface IChapterRepository<Chapter> where Chapter : class
    {
        IEnumerable<Chapter> GetChapters();
        Chapter GetChapter(int ChapterId);
        IQueryable<Chapter> ChapterbyCourseID(int CourseId);
        void PostChapter(Chapter chapter);
        void DeleteChapter(int ChapterId);
    }
}
