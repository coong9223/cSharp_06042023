namespace ASM_AspC4.Models
{
    public class Product
    {
        public Guid idProduct { get; set; }
        public Guid idColor { get; set; }   
        public Guid idMetarial { get; set; }
        public string nameProduct { get; set; } 
        public string nameColor { get; set; }   
        public string nameMetarial { get; set; }
        public int priceProduct { get; set; }   
        public int availableQuantity { get; set; }
        public int statusProduct { get; set; }  
        public string supplier { get; set;}   
        public string description { get; set; }
        public virtual ICollection<BillDetail> BillDetails{ get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
        public virtual Color Colors { get; set; }
        public virtual Metarial Metarials { get; set; }
    }
}
