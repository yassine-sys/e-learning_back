using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Rating
    {
        [Key]
        public int RatingID { get; set; }
        public int Score { get; set; }
        public string CreateDate { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }

        public string UserID { get; set; }

        //  public ApplicationUser ApplicationUser { get; set; }
    }
}
