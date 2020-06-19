using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Section
    {
        public Section()
        {
            paragraphs = new HashSet<Paragraph>();
        }

        [Key]
        public int SectionID { get; set; }
        public string title { get; set; }
        public string Description { get; set; }

        public int ChapterID { get; set; }

        public Chapter Chapter { get; set; }

        public ICollection<Paragraph> paragraphs { get; set; }
    }
}
