using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
  public  class DepartmentDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
