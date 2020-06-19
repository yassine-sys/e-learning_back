using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Course
    {
        public Course()
        {
            chapters = new HashSet<Chapter>();
            //ApplicationUsers = new HashSet<ApplicationUser>();
            Ratings = new HashSet<Rating>();

        }
        [Key]
        public int CourseID { get; set; }

        public string title { get; set; }

        public string Description { get; set; }
        public string OverViewVideo { get; set; }
        public int DepartmentID { get; set; }
        public string UserId { get; set; }
      //  public Department Department { get; set; }
        //public ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public ICollection<Chapter> chapters { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}
