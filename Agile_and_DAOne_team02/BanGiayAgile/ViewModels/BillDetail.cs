using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanGiayAgile.ViewModels;

namespace BanGiayAgile.ViewModels
{
    public class BillDetail
    {
        public Guid idBillDetail { get; set; }
        public Guid idBill { get; set; }
        public Guid idPro { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }
        public int status { get; set; }
        public virtual Bill Bills { get; set; }
        public virtual Product Product { get; set; }
    }
}
