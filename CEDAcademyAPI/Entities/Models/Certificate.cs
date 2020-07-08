using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Certificate : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public int score { get; set; }
        //public string userId { get; set; }
        public int ExamID { get; set; }
        public Exam Exam { get; set; }
        //public ApplicationUser ApplicationUsers { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsActif { get; set; }

    }
}
