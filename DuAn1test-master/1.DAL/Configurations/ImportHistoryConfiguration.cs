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
    public class ImportHistoryConfiguration : IEntityTypeConfiguration<ImportHistory>
    {
        public void Configure(EntityTypeBuilder<ImportHistory> builder)
        {
            builder.ToTable("ImportHistories");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1,1);


            builder.Property(x => x.dateCreate).IsRequired();
            builder.Property(x => x.Amount).IsRequired();
            builder.HasOne(t => t.Product).WithMany(p => p.ImportHistories).HasForeignKey(p => p.ProductID);
            builder.HasOne(t => t.Employee).WithMany(p => p.ImportHistories).HasForeignKey(p => p.EmployeeID);

        }
    }
}
