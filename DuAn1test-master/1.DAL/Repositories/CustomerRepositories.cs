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
    public class CustomerRepositories : ICustomerRepositories
    {
        private List<Customer> _lstCustomer;
        private DatabaseContext _context;
        public CustomerRepositories()
        {
            _lstCustomer = new List<Customer>();
            _context = new DatabaseContext();
        }

        public bool AddCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteCustomer(Customer customer)
        {
            _context.Remove(customer);
            _context.SaveChanges();
            return true;
        }


        public List<Customer> GetCustomerFromDB()
        {
            _lstCustomer = _context.Customers.ToList();
            return _lstCustomer;
        }


        public bool UpdateCustomer(Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
            return true;
        }
    }
}
