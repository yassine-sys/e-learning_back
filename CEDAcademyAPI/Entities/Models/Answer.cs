using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Answer : IEntityBase
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string IsAnswer { get; set; }
        public int ExamID { get; set; }
        public Exam Exam { get; set; }
        public int QuesID { get; set; }
        public Question Question { get; set; }
        //public string userId { get; set; }
        //public ApplicationUser User { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Boolean IsActif { get; set; }
        
    }
}
