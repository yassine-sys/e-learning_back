using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CourseService : ICourseService
    {

        private ICourseRepository repo;

        public CourseService(ICourseRepository repo)
        {
            this.repo = repo;
        }
        public int CourseNumber()

        {
            var query = (from st in db.Courses
                         group st by 1 into g
                         select new
                         {
                             S = g.Count()
                         }).ToList();


            if (query.Count() == 0)
            {
                return 0;
            }
            else
            {
                var x = Int32.Parse(query[0].ToString().Substring(6, 1));


                return x;
            }

        }
    }
}
