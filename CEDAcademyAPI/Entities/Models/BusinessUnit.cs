using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class BusinessUnit
    {
        public BusinessUnit()
        {
            Departments = new HashSet<Department>();
        }
        [Key]
        public int BusinessUnitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}
