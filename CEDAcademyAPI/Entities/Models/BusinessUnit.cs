using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class BusinessUnit : IEntityBase
    {
        public int Id { get; set; }
      
        public BusinessUnit()
        {
            Departments = new HashSet<Department>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Boolean IsActif { get; set; }


        public ICollection<Department> Departments { get; set; }
    }
}
