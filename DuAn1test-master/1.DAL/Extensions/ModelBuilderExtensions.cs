using _1.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { ID = 1, Name = "Khách vãng lai", Phone = "0", Sex = true, Address = "n/a", Point = 0 },
                new Customer() { ID = 2, Name = "Nguyễn Công Tiến", Phone = "0987654321", Sex = true, Address = " 10 Minh Khai, Hà Nội", Point=10000 },
                new Customer() { ID = 3, Name = "Nguyễn Mạnh Thắng", Phone = "0987777777", Sex = true, Address = " 69 Trịnh Văn Bô, Hà Nội", Point = 10000 }
                );
            modelBuilder.Entity<Role>().HasData(
                new Role() { ID = 1, RoleName = "Quản lý" },
                new Role() { ID = 2, RoleName = "Nhân viên" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category() { ID = 1, Name = "Đồ ăn vặt" },
                new Category() { ID = 2, Name = "Nước giải khát" },
                new Category() { ID = 3, Name = "Đồ uống có cồn" },
                new Category() { ID = 4, Name = "Nhu yếu phẩm" }
                );
            modelBuilder.Entity<Producer>().HasData(
                new Producer() { ID = 1, Name = "Oishi" },
                new Producer() { ID = 2, Name = "Coca Cola" },
                new Producer() { ID = 3, Name = "Vodka" },
                new Producer() { ID = 4, Name = "Clear" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, MaSp = "01", Name = "Bim bim Tôm Cay", ProducerID = 1, CategoryID = 1, Price = 6000, OriginalPrice = 5000, Stock = 10, DateCreated = DateTime.Now, Status = true, Note = "" , LinkImage =""},
                new Product() { Id = 2, MaSp = "02", Name = "Coca Cola", ProducerID = 2, CategoryID = 2, Price = 12000, OriginalPrice = 10000, Stock = 20, DateCreated = DateTime.Now, Status = true, Note = "", LinkImage = "" },
                new Product() { Id = 3, MaSp = "03", Name = "Absolut Vodka", ProducerID = 3, CategoryID = 3, Price = 60000, OriginalPrice = 10000, Stock = 50, DateCreated = DateTime.Now, Status = true, Note = "", LinkImage = "" },
                new Product() { Id = 4, MaSp = "04", Name = "Dầu gội Clear Men", ProducerID = 4, CategoryID = 4, Price = 150000, OriginalPrice = 100000, Stock = 5, DateCreated = DateTime.Now, Status = true, Note = "" , LinkImage =""}
                );
            modelBuilder.Entity<Order>().HasData(
                new Order() { Id = 1, dateCreate = DateTime.Now, EmployeeID = 1, CustomerID = 1, TotalPrice = 60000, Status = true },
                new Order() { Id = 2, dateCreate = DateTime.Now, EmployeeID = 2, CustomerID = 2, TotalPrice = 210000, Status = true }
                );
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail() { ProducID = 1, OderID = 1, Quantity = 6, Price = 6000 },
                new OrderDetail() { ProducID = 2, OderID = 1, Quantity = 2, Price = 12000 },
                new OrderDetail() { ProducID = 4, OderID = 2, Quantity = 1, Price = 150000 },
                new OrderDetail() { ProducID = 3, OderID = 2, Quantity = 1, Price = 60000 }
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { ID = 1, MaNV = "NV1", Email = "manhman2806@gmail.com", Password = "123", FullName = "Bùi Thế Mạnh", Status = true, Sex = false, Address = "174 Phương Canh", Dob = DateTime.Now, Phone = "0379200866", IDRoles = 1 },
                new Employee() { ID = 2, MaNV = "NV2", Email = "khoanhph18902@gmail.com", Password = "123", FullName = "Nguyễn Hữu Khoa", Status = true, Sex = true, Address = "173 Phương Canh", Dob = DateTime.Now, Phone = "0972439693", IDRoles = 2 }
                );
        }
    }
}
