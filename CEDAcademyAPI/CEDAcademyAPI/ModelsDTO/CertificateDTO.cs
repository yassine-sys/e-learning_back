using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
   public class CertificateDTO
    {
        public int score { get; set; }
        public Exam Exam { get; set; }


    }
}
