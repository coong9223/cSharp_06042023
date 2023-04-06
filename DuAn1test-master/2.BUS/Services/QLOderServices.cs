using _1.DAL.Context;
using _1.DAL.Entities;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLOderServices : IQLOderServices
    {
        private DatabaseContext _context;
        private IOderRepositories _order;
        private IEmployeeRepositories _employee;
        private ICustomerRepositories _customer;
        private List<Order> _lstOder;
        public QLOderServices()
        {
            _order = new OderRepositories();
            _lstOder = new List<Order>();
            _context = new DatabaseContext();
            _customer = new CustomerRepositories();
        }
        public bool AddOder(Order oder)
        {
            _order.AddOder(oder);
            return true;
        }

        public bool DeleteOder(Order oder)
        {
            _order.DeleteOder(oder);
            return true;
        }

        public List<Order> GetOderFromDB()
        {
            _lstOder = _order.GetOderFromDB();
            return _lstOder;
        }

        public bool UpdateOder(Order oder)
        {
            _order.UpdateOder(oder);
            return true;
        }

        public List<OrderVM> ShowOrder()
        {
            var data = (from o in _context.Oders
                        join c in _context.Customers on o.CustomerID equals c.ID
                        join e in _context.Employees on o.EmployeeID equals e.ID
                        select new OrderVM
                        {
                            ID = o.Id,
                            DateCreated = o.dateCreate,
                            EmployeeEmail = e.Email,
                            CustomerPhoneNumber = c.Phone,
                            TotalPrice = o.TotalPrice,
                            Status = o.Status,
                            Note = o.Note
                        }).ToList();

            return data;
        }
    }
}
