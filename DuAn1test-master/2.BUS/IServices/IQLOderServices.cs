using _1.DAL.Entities;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLOderServices
    {
        bool AddOder(Order oder);
        bool UpdateOder(Order oder);
        bool DeleteOder(Order oder);
        List<Order> GetOderFromDB();
        List<OrderVM> ShowOrder();


    }
}
