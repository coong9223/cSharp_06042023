using ASM_AspC4.Models;


namespace ASM_AspC4.iServices
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
