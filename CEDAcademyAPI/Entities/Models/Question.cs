using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Question :IEntityBase
    {
        public Question()
        {
            Options = new HashSet<Option>();
           // Exams = new HashSet<Exam>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string QuesText { get; set; }
        public string types { get; set; }

        public Quiz Quizzes { get; set; }
        public int? QuizID { get; set; }

        public ICollection<Option> Options { get; set; }
        public Exam Exams { get; set; }
        public int? ExamID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsActif { get; set; }

    }
}
