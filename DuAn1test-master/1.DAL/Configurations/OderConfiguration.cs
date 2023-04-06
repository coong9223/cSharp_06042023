using _1.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    public class OderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1,1);
            builder.Property(x => x.dateCreate);           
            builder.HasOne(x => x.Employee).WithMany(x => x.Oders).HasForeignKey(x => x.EmployeeID);
            builder.HasOne(x => x.Customer).WithMany(x => x.Oders).HasForeignKey(x => x.CustomerID);
            

        }
    }
}
