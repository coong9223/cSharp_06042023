
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModel
{
    public class ProductVm
    {

        public string Id { get; set; }
        public string Masp { get; set; }
        public string Name { get; set; }
        public string ProducerName { get; set; }
        public string CategoryName { get; set; }

        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public DateTime DateCreated { set; get; }
        public string linkImage { set; get; }
        public string Note { set; get; }

        public string Status { set; get; }
    }
}
