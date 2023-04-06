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
    public class OderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OderDetails");
            builder.Property(x => x.Quantity).IsRequired();

            builder.Property(x => x.Price).IsRequired();

            builder.HasKey(x => new { x.OderID, x.ProducID });

            builder.HasOne(x => x.Oder).WithMany(x => x.OderDetails).HasForeignKey(x => x.OderID);
            builder.HasOne(x => x.Product).WithMany(x => x.OderDetails).HasForeignKey(x => x.ProducID);
        }
    }
}
