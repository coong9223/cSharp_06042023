using _1.DAL.Entities;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLOderDetailServices
    {
        bool AddOderDetail(OrderDetail oderDetail);
        bool UpdateOderDetail(OrderDetail oderDetail);
        bool DeleteOderDetail(OrderDetail oderDetail);
        List<OrderDetail> GetOderDetailFromDB();
        List<OrderDetailVM> ShowOrderDetail(int orderID);
    }
}
