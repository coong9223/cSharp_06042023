using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.iServices
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
