using _1.DAL.Context;
using _1.DAL.Entities;
using _1.DAL.iRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class EmployeeRepositories : IEmployeeRepositories
    {
        private List<Employee> _lstEmployees;
        private DatabaseContext _context;
        public EmployeeRepositories()
        {
            _lstEmployees = new List<Employee>();
            _context = new DatabaseContext();
        }


        public bool AddEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return true;
        }


        public bool DeleteEmployee(Employee employee)
        {
            _context.Remove(employee);
            _context.SaveChanges();
            return true;
        }

        public List<Employee> GetEmployeeFromDB()
        {
            _lstEmployees = (from a in _context.Employees
                             select a).ToList();
            return _lstEmployees;
        }

        public bool UpdateEmployee(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
            return true;
        }
    }
}
