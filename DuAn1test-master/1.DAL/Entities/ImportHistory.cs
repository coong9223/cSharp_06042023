using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Entities
{
    public class ImportHistory
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public int ProductID { get; set; }
        public DateTime dateCreate { get; set; }
        public int Amount { get; set; }  //số lượng
        public Employee Employee { get; set; }
        public Product Product { get; set; }


    }
}
