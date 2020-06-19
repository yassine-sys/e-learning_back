using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class QuizResult
    {
        [Key]
        public int ResID { get; set; }
        public int Score { get; set; }
        public int QuizID { get; set; }
        public int Count { get; set; }
        public Quiz Quiz { get; set; }
        //public string userId { get; set; }
        //public ApplicationUser User { get; set; }
        public DateTime time { get; set; }
    }
}
