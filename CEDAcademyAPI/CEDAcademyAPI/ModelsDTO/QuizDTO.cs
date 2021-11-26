using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
   public class QuizDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; }

    }
}
