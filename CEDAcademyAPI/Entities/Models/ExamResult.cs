using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ExamResult : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public int Score { get; set; }
        public string TimeSpent { get; set; }
        public int ExamID { get; set; }
        public Exam Exam { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsActif { get; set; }

        // public string userId { get; set; }
        // public ApplicationUser User { get; set; }
    }
}
