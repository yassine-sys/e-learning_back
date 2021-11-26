using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
  public  class QuizResultDTO
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int Count { get; set; }
        public Quiz Quiz { get; set; }
        public int QuizID { get; set; }

    }
}
