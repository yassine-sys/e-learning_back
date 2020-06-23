using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    interface IDepartmentRepository<Department> where Department:class
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartmentByID(int DepartmentID);
        void InsertDepartment(Department department);
        void DeleteDepartment(int DepartmentID);
        void UpdateDepartment(Department department);
    }
}
