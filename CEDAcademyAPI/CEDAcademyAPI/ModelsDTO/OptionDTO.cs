using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
  public  class OptionDTO
    {
        public string OptionText { get; set; }
        public ICollection<Question> Questions { get; set; }
        public bool values { get; set; }
    }
}
