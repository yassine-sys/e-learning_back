using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
   public class SectionDTO
    {
        public string title { get; set; }
        public string Description { get; set; }
        public Chapter Chapter { get; set; }

    }
}
