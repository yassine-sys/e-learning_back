﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface IDepartmentService
    {
        Department Get(int id);

        IEnumerable<ApplicationIdentity> GetUsers(int departmentId);
    }
}
