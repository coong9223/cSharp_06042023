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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.OriginalPrice).IsRequired();
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.LinkImage).IsRequired();
            builder.Property(x => x.Note).IsRequired().HasMaxLength(200);
            builder.HasOne(t => t.Producer).WithMany(p => p.Product).HasForeignKey(p => p.ProducerID);
            builder.HasOne(t => t.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryID);

        }
    }
}
