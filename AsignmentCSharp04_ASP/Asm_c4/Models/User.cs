namespace Asm_c4.Models
{
    public class User
    {
        public Guid idUser { get; set; }
        public string nameUser { get; set; }
        public string emailUser { get; set; }
        public string passwordUser { get; set; }
        public string nameRole { get; set; }
        public int statusUser { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
