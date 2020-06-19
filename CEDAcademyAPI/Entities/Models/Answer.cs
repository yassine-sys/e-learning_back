using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Answer
    {
        [Key]
        public int AnsID { get; set; }
        public string IsAnswer { get; set; }
        public int ExamID { get; set; }
        public Exam Exam { get; set; }
        public int QuesID { get; set; }
        public Question Question { get; set; }
        //public string userId { get; set; }
        //public ApplicationUser User { get; set; }
    }
}
