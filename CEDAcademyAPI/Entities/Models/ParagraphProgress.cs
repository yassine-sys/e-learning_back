using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class ParagraphProgress
    {

        [Key]
        public int ProgressID { get; set; }
        public int ParagraphID { get; set; }
        public int SectionID { get; set; }
        public int ChapterID { get; set; }
        public int CourseID { get; set; }
        public string userId { get; set; }

        public DateTime Date { get; set; }

    }
}
