﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModelsDTO
{
  public  class FileProgressDTO
    {
        public float Pourcentage { get; set; }
        public float CurrentTime { get; set; }
        public File File { get; set; }

    }
}
