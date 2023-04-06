namespace Asm_c4.Models
{
    public class Product
    {
        public Guid idProduct { get; set; }
        public string nameProduct { get; set; }
        public string LinkAnh { get; set; }
        public int priceProduct { get; set; }
        public int availableQuantity { get; set; }
        public int statusProduct { get; set; }
        public string supplier { get; set; }
        public string description { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
