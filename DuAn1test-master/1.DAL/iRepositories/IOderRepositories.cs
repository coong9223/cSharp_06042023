using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.iRepositories
{
    public interface IOderRepositories
    {
        bool AddOder(Order oder);
        bool UpdateOder(Order oder);
        bool DeleteOder(Order oder);
        List<Order> GetOderFromDB();
    }
}
