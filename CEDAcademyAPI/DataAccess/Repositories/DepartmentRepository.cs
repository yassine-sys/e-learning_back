using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class DepartmentRepository<Department>: IDepartmentRepository<Department> where Department:class
    {
        private ApplicationContext context;
        public DepartmentRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }
        public Department GetDepartmentByID(int DepartmentID)
        {
            return context.Departments.Find(DepartmentID);
        }

        public void InsertDepartment(Department department)
        {
            context.Departments.Add(department);
        }

        public void DeleteDepartment(int DepartmentID)
        {
            Department department = context.Departments.Find(DepartmentID);
            context.Departments.Remove(department);
        }

        public void UpdateDepartment(Department department)
        {
            context.Entry(department).State = EntityState.Modified;
        }
    }
}
