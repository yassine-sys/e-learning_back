using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Option : IEntityBase
    {
        public Option()
        {
            Questions = new HashSet<Question>();
        }

        [Key]
        public int Id { get; set; }
        public string OptionText { get; set; }
        public ICollection<Question> Questions { get; set; }
        public bool values { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsActif { get; set; }
        public int QuesId { get; set; }
    }
}
