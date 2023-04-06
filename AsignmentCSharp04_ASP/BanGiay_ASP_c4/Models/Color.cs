namespace BanGiay_ASP_c4.Models
{
    public class Color
    {
        public Guid idColor { get; set; }
        public string nameColor { get; set; }
        public int statusColor { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
