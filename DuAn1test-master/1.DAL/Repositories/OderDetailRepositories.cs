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
    public class OderDetailRepositories : IOderDetailRepositories
    {
        private List<OrderDetail> _lstOderDetail;
        private DatabaseContext _context;
        public OderDetailRepositories()
        {
            _lstOderDetail = new List<OrderDetail>();
            _context = new DatabaseContext();
        }

        public bool AddOderDetail(OrderDetail oderDetail)
        {
            _context.Add(oderDetail);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteOderDetail(OrderDetail oderDetail)
        {
            _context.Remove(oderDetail);
            _context.SaveChanges();
            return true;
        }

        public List<OrderDetail> GetOderDetailFromDB()
        {
            _lstOderDetail = (from a in _context.OderDetails
                        select a).ToList();
            return _lstOderDetail;
        }

        public bool UpdateOderDetail(OrderDetail oderDetail)
        {
            _context.Update(oderDetail);
            _context.SaveChanges();
            return true;
        }
    }
}
