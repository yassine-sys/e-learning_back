using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Section :IEntityBase
    {
        public Section()
        {
            paragraphs = new HashSet<Paragraph>();
        }

        [Key]
        public int Id { get; set; }
        public string title { get; set; }
        public string Description { get; set; }

        public int ChapterID { get; set; }

        public Chapter Chapter { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Boolean IsActif { get; set; }


        public ICollection<Paragraph> paragraphs { get; set; }
    }
}
