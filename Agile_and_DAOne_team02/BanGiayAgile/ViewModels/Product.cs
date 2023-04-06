using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanGiayAgile.ViewModels;

namespace BanGiayAgile.ViewModels
{
    public class Product
    {
        public Guid idPro { get; set; }
        public string nameProduct { get; set; }
        public string nameColor { get; set; }
        public string nameMaterial { get; set; }
        public string typeSize { get; set; }
        public DateTime DImport { get; set; }
        public DateTime DSell { get; set; }
        public decimal priceImport { get; set; }
        public decimal price { get; set; }
        public int availableQuantity { get; set; }
        public string description { get; set; }
        public int status { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
