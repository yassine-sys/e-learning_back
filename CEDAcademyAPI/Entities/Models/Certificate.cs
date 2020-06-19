using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Certificate
    {
        [Key]
        public int CertifID { get; set; }
        public int score { get; set; }
        //public string userId { get; set; }
        public int ExamID { get; set; }
        public Exam Exam { get; set; }
        //public ApplicationUser ApplicationUsers { get; set; }
    }
}
