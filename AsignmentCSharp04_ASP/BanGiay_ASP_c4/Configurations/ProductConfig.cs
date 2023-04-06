using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(v => v.idProduct);
            builder.HasOne(v => v.Colors).WithMany(v => v.Products).HasForeignKey(v => v.idColor);
            builder.HasOne(v => v.Metarials).WithMany(v => v.Products).HasForeignKey(v => v.idMetarial);
            builder.Property(v => v.nameColor).HasColumnType("nvarchar(100)");
            builder.Property(v => v.nameMetarial).HasColumnType("nvarchar(100)");
            builder.Property(v => v.nameProduct).HasColumnType("nvarchar(100)");
            builder.Property(v => v.supplier).IsUnicode(true).IsFixedLength().HasMaxLength(100);
        }
    }
}
