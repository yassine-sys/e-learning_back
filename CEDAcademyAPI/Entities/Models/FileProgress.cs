using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class FileProgress : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public float Pourcentage { get; set; }
        public float CurrentTime { get; set; }
       // public string UserId { get; set; }

        //public ApplicationUser ApplicationUser { get; set; }
        public int FileId { get; set; }
        public File File { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Boolean IsActif { get; set; }

    }
}

