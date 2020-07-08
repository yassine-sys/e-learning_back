using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
  public  class QuestionDTO
    {
        public string QuesText { get; set; }
        public string types { get; set; }

        //a reference object because the multiplicity of Quiz is one)
        public ICollection<Quiz> Quizzes { get; set; }
        public ICollection<Option> Options { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
