using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
  public  class ChapterDTO
    {
        public int Id { get; set; }

        public string title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }

        public ICollection<Section> sections { get; set; }
    }
}
