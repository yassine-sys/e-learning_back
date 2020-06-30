using Business.IServices;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;

namespace Business.Services
{
    public class DepartmentService : ServiceBase<Department>, IDepartmentService
    {
        private IDepartmentRepository repo;

        public DepartmentService(IDepartmentRepository repo)
             : base((RepositoryBase<Department>)repo)
        {
            this.repo = repo;
          
        }

       

       
    }
}
