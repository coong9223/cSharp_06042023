using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool Sex { get; set; }
        public string Address { get; set; }
        public int? Point { get; set; }
        public List<Order> Oders { get; set; }
    }
}
