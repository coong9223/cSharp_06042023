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
    public class QLOderDetailServices : IQLOderDetailServices
    {
        private IOderDetailRepositories _orderDetail;
        private IOderRepositories _order;
        private IProductRepositories _product;
        private DatabaseContext _context;
        private List<OrderDetail> _lstOderDetails;
        public QLOderDetailServices()
        {
            _orderDetail = new OderDetailRepositories();
            _order = new OderRepositories();
            _product = new ProductRepositories();
            _lstOderDetails = new List<OrderDetail>();
            _context = new DatabaseContext();
        }

        public bool AddOderDetail(OrderDetail oderDetail)
        {
            _orderDetail.AddOderDetail(oderDetail);
            return true;
        }

        public bool DeleteOderDetail(OrderDetail oderDetail)
        {
            _orderDetail.DeleteOderDetail(oderDetail);
            return true;
        }

        public List<OrderDetail> GetOderDetailFromDB()
        {
            _lstOderDetails = _orderDetail.GetOderDetailFromDB();
            return _lstOderDetails;
        }

        public bool UpdateOderDetail(OrderDetail oderDetail)
        {
            _orderDetail.UpdateOderDetail(oderDetail);
            return true;
        }
        public List<OrderDetailVM> ShowOrderDetail(int orderID)
        {
            var data = (from od in _context.OderDetails
                        join o in _context.Oders on od.OderID equals o.Id
                        join p in _context.Products on od.ProducID equals p.Id
                        where od.OderID == orderID
                        select new OrderDetailVM
                        {
                            ProductID = od.ProducID,
                            ProductName=p.Name,
                            Price= od.Price,
                            Quantity = od.Quantity
                        }).ToList();
            return data;
        }
    }
}
