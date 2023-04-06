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
    public class EmployeeConfigguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn(1, 1);
            builder.HasOne(t => t.Roles).WithMany(p => p.Employees).HasForeignKey(p => p.IDRoles);

            //builder.Property(x => x.Email).IsRequired();
            //builder.Property(x => x.Password).IsRequired();
            //builder.Property(x => x.FullName).IsRequired().HasMaxLength(200);
            //builder.Property(x => x.Address).HasMaxLength(200);
            //builder.Property(x => x.Dob).IsRequired();
            //builder.Property(x => x.Phone).IsRequired().HasMaxLength(10);

        }
    }
}
