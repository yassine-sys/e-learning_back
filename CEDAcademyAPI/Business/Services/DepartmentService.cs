using Business.IServices;
using DataAccess.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;

namespace Business.Services
{
    public class DepartmentService : IDepartmentService
    {
        private IDepartmentRepository repo;

        public DepartmentService(IDepartmentRepository repo)
        {
            this.repo = repo;
          
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
           
        }

        public IEnumerable<ApplicationIdentity> GetUsers(int departmentId)
        {
            throw new NotImplementedException();
        }
    }
}
