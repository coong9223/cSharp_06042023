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
    public class QLCustomerServices : IQLCustomerServices
    {
        private ICustomerRepositories _customer;
        private List<Customer> _lstCustomer;
        public QLCustomerServices()
        {
            _customer = new CustomerRepositories();
            _lstCustomer = new List<Customer>();
        }

        public bool AddCustomer(Customer customer)
        {
            _customer.AddCustomer(customer);
            return true;
        }

        public bool DeleteCustomer(Customer customer)
        {
            _customer.DeleteCustomer(customer);
            return true;
        }

        public List<Customer> GetCustomerFromDB()
        {
            _lstCustomer = _customer.GetCustomerFromDB();
            return _lstCustomer;
        }

        public bool UpdateCustomer(Customer customer)
        {
            _customer.UpdateCustomer(customer);
            return true;
        }
    }
}
