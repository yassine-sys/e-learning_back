using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class File : IEntityBase
    {
        public File()
        {
            Progress = new HashSet<FileProgress>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string FileName { get; set; }
        public string FileDuration { get; set; }
        public string FileTitle { get; set; }
        public string FileDescription { get; set; }
        // public int ParagraphId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Boolean IsActif { get; set; }
        public Paragraph Paragraph { get; set; }
        public FileType FileType { get; set; }
        public ICollection<FileProgress> Progress { get; set; }
    }
}
