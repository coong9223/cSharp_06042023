using ASM_AspC4.Models;
namespace ASM_AspC4.iServices
{
    public interface iCart
    {
        public bool createCart(Cart c);
        public bool updateCart(Cart c);
        public bool deleteCart(Guid id);
        public List<Cart> getAllCart();
        public Cart getById(Guid id);
    }
}
