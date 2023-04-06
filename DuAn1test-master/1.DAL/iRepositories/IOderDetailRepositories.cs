using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.iRepositories
{
    public interface IOderDetailRepositories
    {
        bool AddOderDetail(OrderDetail oderDetail);
        bool UpdateOderDetail(OrderDetail oderDetail);
        bool DeleteOderDetail(OrderDetail oderDetail);
        List<OrderDetail> GetOderDetailFromDB();

    }
}
