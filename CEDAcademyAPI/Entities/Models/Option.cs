using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Option
    {
        public Option()
        {
            Questions = new HashSet<Question>();
        }

        [Key]
        public int OpID { get; set; }
        public string OptionText { get; set; }
        public ICollection<Question> Questions { get; set; }
        public bool values { get; set; }
    }
}
