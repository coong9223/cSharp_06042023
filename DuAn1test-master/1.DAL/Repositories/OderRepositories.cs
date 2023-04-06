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
    public class OderRepositories : IOderRepositories
    {
        private List<Order> _lstOder;
        private DatabaseContext _context;
        public OderRepositories()
        {
            _lstOder = new List<Order>();
            _context = new DatabaseContext();
        }

        public bool AddOder(Order oder)
        {
            _context.Add(oder);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteOder(Order oder)
        {
            _context.Remove(oder);
            _context.SaveChanges();
            return true;
        }

        public List<Order> GetOderFromDB()
        {
            _lstOder = _context.Oders.ToList();
            return _lstOder;
        }

        public bool UpdateOder(Order oder)
        {
            _context.Update(oder);
            _context.SaveChanges();
            return true;
        }
    }
}
