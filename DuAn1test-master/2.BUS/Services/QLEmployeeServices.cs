using _1.DAL.Context;
using _1.DAL.Entities;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLEmployeeServices : IQLEmployeeServices
    {
        private IEmployeeRepositories _iQLEmployee;
        private List<Employee> _lstEmployee;
        private DatabaseContext _context;

        public QLEmployeeServices()
        {
            _iQLEmployee = new EmployeeRepositories();
            _lstEmployee = new List<Employee>();
            _context = new DatabaseContext();
        }

        public bool AddEmployee(Employee employee)
        {
            //var data = _context.Employees.FirstOrDefault(o => o.UserName == employee.UserName);
            //if (data == null)
            //{
                _iQLEmployee.AddEmployee(employee);
                return true;
            //}
            //return false;
        }

        public bool DeleteEmployee(Employee employee)
        {
            _iQLEmployee.DeleteEmployee(employee);
            return true;
        }

        public List<Employee> GetEmployeeFromDB()
        {
            _lstEmployee = _iQLEmployee.GetEmployeeFromDB();
            return _lstEmployee;
        }

        public bool UpdateEmployee(Employee employee)
        {
            _iQLEmployee.UpdateEmployee(employee);
            return true;
        }
    }
}
