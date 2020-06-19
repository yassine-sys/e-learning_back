using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Paragraph
    {
        public Paragraph()
        {
            files = new HashSet<File>();
        }
        [Key]
        public int ParagraphID { get; set; }
        public string title { get; set; }
        public string Description { get; set; }


        public int SectionID { get; set; }
        public string Video { get; set; }
        public string Pdf { get; set; }
        public Section Section { get; set; }
        public ICollection<File> files { get; set; }
        //public Quiz Quiz { get; set; }
    }
}
