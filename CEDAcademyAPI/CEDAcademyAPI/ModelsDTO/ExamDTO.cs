using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
  public  class ExamDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<ExamResult> ExamResults { get; set; }


    }
}
