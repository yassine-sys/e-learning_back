using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
   public class Paragraph : IEntityBase
    {
        public Paragraph()
        {
            files = new HashSet<File>();
        }
        [Key]
        public int Id { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public int SectionID { get; set; }
        public string Video { get; set; }
        public string Pdf { get; set; }
        public Section Section { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsActif { get; set; }
        public ICollection<File> files { get; set; }
        //public Quiz Quiz { get; set; }
    }
}
