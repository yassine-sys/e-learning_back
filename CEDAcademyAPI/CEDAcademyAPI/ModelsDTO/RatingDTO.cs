using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
  public  class RatingDTO
    {
        public int Score { get; set; }
        public Course Course { get; set; }

    }
}
