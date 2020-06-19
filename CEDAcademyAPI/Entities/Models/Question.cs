using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Question
    {
        public Question()
        {
            Options = new HashSet<Option>();
            Exams = new HashSet<Exam>();
            Quizzes = new HashSet<Quiz>();
        }

        [Key]
        public int QuesID { get; set; }
        [Required]
        public string QuesText { get; set; }
        public string types { get; set; }

        //a reference object because the multiplicity of Quiz is one)
        public ICollection<Quiz> Quizzes { get; set; }
        public ICollection<Option> Options { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
