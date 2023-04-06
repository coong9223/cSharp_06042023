namespace BanGiay_ASP_c4.Models
{
    public class Metarial
    {
        public Guid idMetarial { get; set; }
        public string nameMetarial { get; set; }
        public int statusMetarial { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
