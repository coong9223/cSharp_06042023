namespace BanGiay_ASP_c4.Models
{
    public class BillDetail
    {
        public Guid idBDetail { get; set; }
        public Guid idProduct { get; set; }
        public Guid idBill { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int statusBDetail { get; set; }
        public virtual Bill Bills { get; set; }
        public virtual Product Products { get; set; }
    }
}
