using _1.DAL.Configurations;
using _1.DAL.Entities;
using _1.DAL.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Context
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        

        
        //chỗ này truyền các table
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; } 
        public virtual DbSet<Order> Oders { get; set; } 
        public virtual DbSet<OrderDetail> OderDetails { get; set; } 
        public virtual DbSet<Producer> Producers { get; set; } 
        public virtual DbSet<Product> Products { get; set; } 
        public virtual DbSet<ImportHistory> ImportHistories { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        //public virtual DbSet<ProductInCategory> ProductInCategories { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfigguration()); 
            modelBuilder.ApplyConfiguration(new OderConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new OderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProducerConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ImportHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());

            modelBuilder.Seed(); //gọi cái này để seeding data
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Lấy code về muốn kết nối database thì phải sửa lại dòng này
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FOSRL05\THANG;Initial Catalog=databaseDuAn1;Persist Security Info=True; User ID =thangnm; Password =123");
            }
        }
        
    }
}
