using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Department
    {
        public Department()
        {
            // ApplicationUsers = new HashSet<ApplicationUser>();
            Courses = new HashSet<Course>();
        }
        [Key]
        public int DepartmentID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public int BusinessUnitId { get; set; }

        public BusinessUnit BusinessUnit { get; set; }

        public ICollection<Course> Courses { get; set; }

        // public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
