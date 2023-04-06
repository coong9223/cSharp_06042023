using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.iServices
{
    public interface iBill
    {
        public bool createBill(Bill b);
        public bool updateBill(Bill b);
        public bool deleteBill(Guid id);
        public List<Bill> getAllBill();
        public Bill getById(Guid id);
    }
}
