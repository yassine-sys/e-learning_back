using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Department : IEntityBase
    {
        public Department()
        {
            // ApplicationUsers = new HashSet<ApplicationUser>();
            Courses = new HashSet<Course>();
        }
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
       // [ForeignKey("BusinessUnit")]
        public int BusinessUnitId{ get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        public ICollection<Course> Courses { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsActif { get; set; }


         public ICollection<IdentityUser> ApplicationUsers { get; set; }
    }
}
