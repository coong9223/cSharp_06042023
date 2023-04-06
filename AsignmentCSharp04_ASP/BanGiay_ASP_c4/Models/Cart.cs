namespace BanGiay_ASP_c4.Models
{
    public class Cart
    {
        public Guid idUserFK { get; set; }
        public string description { get; set; }
        public int statusCart { get; set; }
        public virtual User Users { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
