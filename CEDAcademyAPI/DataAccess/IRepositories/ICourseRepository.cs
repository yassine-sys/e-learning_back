using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface ICourseRepository<Course> where Course : class
    {
        IEnumerable<Course> GetCourses();
        Course GetCourse(int CourseId);
        void PostCourse(Course course);
        void DeleteCourse(int CourseId);
    }
}
