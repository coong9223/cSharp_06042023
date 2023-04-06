using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Asm_c4.Models;

namespace Asm_c4.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(v => v.idProduct);
            builder.Property(v => v.nameProduct).HasColumnType("nvarchar(100)");
            builder.Property(v => v.supplier).IsUnicode(true).IsFixedLength().HasMaxLength(100);
        }
    }
}
