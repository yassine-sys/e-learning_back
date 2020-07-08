using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ParagraphProgress: IEntityBase
    {

        [Key]
        public int Id { get; set; }
        public int ParagraphID { get; set; }
        public int SectionID { get; set; }
        public int ChapterID { get; set; }
        public int CourseID { get; set; }
        public string userId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsActif { get; set; }


    }
}
