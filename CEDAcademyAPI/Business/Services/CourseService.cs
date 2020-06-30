using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CourseService : ICourseService
    {

        private ICourseRepository CourseRepository;

        public CourseService(ICourseRepository CourseRepository)
        {
            this.CourseRepository = CourseRepository;
        }
        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }
        public Course GetCourseById(int idCourse)
        {
            throw new NotImplementedException();
        }
        public void AddCourse(Course c)
        {

        }
        public void UpdateCourse(Course c)
        {

        }
        public void DeleteCourse(Course c)
        {

        }
        public int GetCourseNumber()
        {
            return CourseRepository.GetAll().Count();
        }                
    }
}
