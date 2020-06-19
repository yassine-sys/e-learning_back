using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Quiz
    {
        public Quiz()
        {
            Questions = new HashSet<Question>();
            QuizResults = new HashSet<QuizResult>();
        }

        [Key]
        public int QuizID { get; set; }
        public string Title { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }

        // quiz creator
        //public string userId { get; set; }
        //public ApplicationUser User { get; set; }

        //Navigation property
        //returns a collection because the multiplicity of Question is many
        public ICollection<Question> Questions { get; set; }
        public ICollection<QuizResult> QuizResults { get; set; }
    }
}
