

namespace _1.DAL.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string MaNV { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Status { get; set; }
        public bool Sex { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public int IDRoles { get; set; }
        public string? LinkAnh { get; set; }    
        public Role Roles { get; set; }
        public List<Order> Oders { get; set; }
        public List<ImportHistory> ImportHistories { get; set; }

    }
}
