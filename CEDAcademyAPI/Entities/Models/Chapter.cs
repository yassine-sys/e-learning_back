using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Chapter
    {
        public Chapter()
        {
            sections = new HashSet<Section>();
        }

        [Key]
        public int ChapterID { get; set; }
        public string title { get; set; }
        public string Description { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }

        public ICollection<Section> sections { get; set; }
    }
}
