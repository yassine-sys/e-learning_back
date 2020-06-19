using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class ExamResult
    {
        [Key]
        public int ResID { get; set; }
        public int Score { get; set; }
        public string TimeSpent { get; set; }
        public int ExamID { get; set; }
        public Exam Exam { get; set; }
        // public string userId { get; set; }
        // public ApplicationUser User { get; set; }
    }
}
