using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModel
{
    public class OrderVM
    {
        public int ID { get; set; }
        public DateTime DateCreated { get; set; }
        public string EmployeeEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Status { get; set; }
        public string? Note { get; set; }
    }
}
