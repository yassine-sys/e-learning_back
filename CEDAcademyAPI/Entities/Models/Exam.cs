using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Exam
    {
        public Exam()
        {
            Questions = new HashSet<Question>();
            ExamResults = new HashSet<ExamResult>();
            Certificates = new HashSet<Certificate>();

        }

        [Key]
        public int ExamID { get; set; }
        public string Title { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public string userId { get; set; }
        //public ApplicationUser User { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<ExamResult> ExamResults { get; set; }
    }
}
