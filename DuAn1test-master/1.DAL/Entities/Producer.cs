
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Entities
{
    public class Producer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Product> Product { get; set; }

    }
}
