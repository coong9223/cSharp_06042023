namespace ASM_AspC4.Models
{
    public class Role
    {
        public Guid idRole { get; set; }
        public string nameRole { get; set; }    
        public int statusRole { get; set; } 
        public virtual ICollection<User> Users { get; set; }    
    }
}
