using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
   public class ParagraphDTO
    {
        public string title { get; set; }
        public string Description { get; set; }
        public string Video { get; set; }
        public string Pdf { get; set; }
        public Section Section { get; set; }
        public ICollection<File> files { get; set; }

    }
}
