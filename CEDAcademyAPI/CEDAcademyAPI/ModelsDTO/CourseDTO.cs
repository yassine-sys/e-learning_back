using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
  public  class CourseDTO
    {
        public string title { get; set; }

        public string Description { get; set; }
        public string OverViewVideo { get; set; }
        public ICollection<Chapter> chapters { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public Department Department { get; set; }
    }
}
