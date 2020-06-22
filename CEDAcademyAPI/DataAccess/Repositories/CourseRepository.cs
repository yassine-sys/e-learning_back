using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IRepositories;


namespace DataAccess.Repositories
{
    public class CourseRepository<Course> : ICourseRepository<Course> where Course : class
    {
        readonly ApplicationContext db;

        public CourseRepository(ApplicationContext context)
        {
            db = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return db.Courses.ToList();
        }
        public Course GetCourse(int CourseId)
     
        {
            return db.Courses.Find(CourseId);
        }
        public void PostCourse(Course course)
        {
            db.Courses.Add(course);
            db.SaveChanges();
        }
        public void DeleteCourse(int CourseId)
        {
            Course course = db.Courses.Find(CourseId);
            db.Courses.Remove(course);
            db.SaveChanges();

        }


    }
}
