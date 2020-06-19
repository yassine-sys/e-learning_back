using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class FileProgress
    {
        [Key]
        public int ProgressID { get; set; }
        public float Pourcentage { get; set; }
        public float CurrentTime { get; set; }
        public string UserId { get; set; }

        //public ApplicationUser ApplicationUser { get; set; }
        public int FileId { get; set; }
        public File File { get; set; }
    }
}

