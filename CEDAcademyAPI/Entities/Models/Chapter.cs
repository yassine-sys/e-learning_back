using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Chapter : IEntityBase
    {
        public Chapter()
        {
            sections = new HashSet<Section>();
        }

        [Key]
        public int Id { get; set; }
        public string title { get; set; }
        public string Description { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }

        public ICollection<Section> sections { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Boolean IsActif { get; set; }

    }
}
