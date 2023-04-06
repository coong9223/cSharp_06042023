using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BanGiay_ASP_c4.Models
{
    public class ShopGiayDbContext:DbContext
    {
        public ShopGiayDbContext() { }
        public ShopGiayDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Metarial> Metarials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<CartDetail> CasrtDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H0KQCAN;Initial Catalog=BanGiay_ASP_c4;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
