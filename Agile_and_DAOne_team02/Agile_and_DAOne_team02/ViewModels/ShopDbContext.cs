using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Agile_and_DAOne_team02.ViewModels
{
	public class ShopDbContext:DbContext
	{
		public ShopDbContext() { }
		public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }
		public DbSet<Color>Colors { get; set; }
		public DbSet<Material>Materials { get; set; }
		public DbSet<Producer> Producers { get; set; }
		public DbSet<Size> Sizes { get; set; }	
		public DbSet<Role> Roles { get; set; }
		public DbSet<Staff> Staffs { get; set;}
		public DbSet<Customer> Customers { get; set; }	
		public DbSet<Product> Products { get; set; }
		public DbSet<Bill> Bills { get; set; }	
		public DbSet<ProductDetail> ProductDetails { get; set; }	
		public DbSet<BillDetail> BillsDetails { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-H0KQCAN;Initial Catalog=Agile_DAOne_team02;Integrated Security=True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
