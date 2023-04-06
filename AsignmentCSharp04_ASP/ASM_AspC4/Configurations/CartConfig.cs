using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASM_AspC4.Models;


namespace ASM_AspC4.Configurations
{
    public class CartConfig : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(v => v.idUser);
            builder.Property(v => v.description).HasColumnType("nvarchar(256)");
        }
    }
}
