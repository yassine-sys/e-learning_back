using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
   public class BusinessUnitDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
