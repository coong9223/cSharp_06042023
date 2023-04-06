using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanGiayAgile.ViewModels;

namespace BanGiayAgile.ViewModels
{
    public class Bill
    {
        public Guid idBill { get; set; }
        public Guid idStaff { get; set; }
        public Guid idCustomer { get; set; }
        public string codeBill { get; set; }
        public DateTime DoCreation { get; set; }
        public DateTime DoPayment { get; set; }
        public int statusBill { get; set; }
        public virtual Staff Staffs { get; set; }
        public virtual Customer Customers { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
