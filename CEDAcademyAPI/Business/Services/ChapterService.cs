using Business.IServices;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class ChapterService : ServiceBase<Chapter>, IChapterService
    {
        private readonly IChapterRepository chapterRepository;
        private readonly ICourseRepository courseRepository;

        public ChapterService(IChapterRepository chapterRepository, ICourseRepository courseRepository)
            : base((RepositoryBase<Chapter>)chapterRepository)
        {
            this.chapterRepository = chapterRepository;
            this.courseRepository = courseRepository;
        }

        public IEnumerable<Chapter> GetChapterbyCourseId(int courseId)
        {
            var chapters = this.chapterRepository
                .GetAll()
                .Where(x => x.CourseID == courseId);

            return chapters;
        }

        public IEnumerable<Chapter> GetChapterDetailsByCourseID(int CourseId)
        {

            var query = this.chapterRepository
                .GetAll()
                .Where(x => x.CourseID == CourseId);

            var chapters = query.AsQueryable<Chapter>();
            List<Chapter> listChapters = new List<Chapter>();
            Course course = this.courseRepository.GetById(CourseId);
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
