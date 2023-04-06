namespace ASM_AspC4.Models
{
    public class Bill
    {
        public Guid idBill { get; set; }    
        public Guid idUser { get; set; }   
        public DateTime createDate { get; set; }
        public int statusBill { get; set; }
        public virtual User Users { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
