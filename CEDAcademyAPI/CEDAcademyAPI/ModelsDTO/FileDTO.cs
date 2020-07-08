using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
   public class FileDTO
    {
        public string FileName { get; set; }
        public string FileDuration { get; set; }
        public string FileTitle { get; set; }
        public string FileDescription { get; set; }
        public Paragraph Paragraph { get; set; }
        public FileType FileType { get; set; }
        public ICollection<FileProgress> Progress { get; set; }
    }
}
