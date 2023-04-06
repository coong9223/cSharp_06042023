using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Entities
{
    public class OrderDetail
    {
        
        public int ProducID { get; set; }
        public int OderID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Order Oder { get; set; }
        public Product Product { get; set; }
             
    }
}
