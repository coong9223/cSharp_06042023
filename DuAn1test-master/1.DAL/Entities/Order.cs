
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime dateCreate { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Status { get; set; }
        public string? Note { get; set; }
        public Employee Employee { get; set; }
        //trong oder có 1 employee tức là 1 thằng đăng nhập 

        public List<OrderDetail> OderDetails { get; set; }
        //trong odre có nhiều oderdetail
        public Customer Customer { get; set; }
    }
}
