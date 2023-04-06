
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? MaSp { get; set; } //chỗ này cần quết mã vạch
        public string Name { get; set; }
        public int ProducerID { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public DateTime DateCreated { set; get; }
        public string? LinkImage { set; get; }
        public string? Note { set; get; }
        public bool Status { set; get; }
        public Producer Producer { set; get; }
        public Category Category { set; get; }
        
        public List<OrderDetail> OderDetails { get; set; }
        public List<ImportHistory> ImportHistories { get; set; }
       // public List<ProductInCategory> ProductInCategories { get; set; }


    }
}
