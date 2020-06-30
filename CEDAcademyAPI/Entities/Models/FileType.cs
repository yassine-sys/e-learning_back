using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class FileType
    {
        public int TypeId { get; set; }
        public FileTypeName TypeName { get; set; }
        public ICollection<File> Files { get; set; }
    }
}
