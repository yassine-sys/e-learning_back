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

namespace Business.Services
{
    public class CourseService : ServiceBase<Course>, ICourseService
    {

        private ICourseRepository CourseRepository;

        public CourseService(ICourseRepository CourseRepository)
            : base((RepositoryBase<Course>)CourseRepository)
        {
            this.CourseRepository = CourseRepository;
        }
       public int GetCourseNumber()
        {
            return CourseRepository.GetAll().Count();
        }                
    }
}
