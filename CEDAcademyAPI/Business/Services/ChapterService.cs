using Business.IServices;
using DataAccess.Infrastructure;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ChapterService:IChapterService
    {        
        readonly CEDAcademyDbContext db;

        public ChapterService(CEDAcademyDbContext context)
        {
            db = context;
        }
        public List<Chapter> ChapterDetailsByCourseID(int CourseID)

        {
            var query = from C in db.Chapters
                        where C.CourseID == CourseID
                        select C;
            var chapters = query.AsQueryable<Chapter>();
            List<Chapter> listChapters = new List<Chapter>();
            Course course = db.Courses.Find(CourseID);
            // query : res list des chapters : C
            foreach (Chapter obj in chapters)
            {
                // create chapter
                Chapter item = new Chapter();
                item.Course = course;
                item.sections = null;
                item.title = obj.title;
                item.Description = obj.Description;
                item.Id = obj.Id;
                item.CourseID = obj.CourseID;
                listChapters.Add(item);
            }


            return listChapters;
        }
    }
}
