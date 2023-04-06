namespace BanGiay_ASP_c4.Models
{
    public class CartDetail
    {
        public Guid idCDetail { get; set; }
        public Guid idUserFK { get; set; }
        public Guid idProduct { get; set; }
        public int quantity { get; set; }
        public int statusCDetail { get; set; }
        public virtual Cart Carts { get; set; }
        public virtual Product Products { get; set; }
    }
}
