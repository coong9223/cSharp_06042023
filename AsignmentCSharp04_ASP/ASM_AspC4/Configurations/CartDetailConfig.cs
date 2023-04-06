using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASM_AspC4.Models;


namespace ASM_AspC4.Configurations
{
    public class CartDetailConfig : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.HasKey(v => v.idCDetail);
            builder.HasOne(v => v.Carts).WithMany(v => v.CartDetails).HasForeignKey(v => v.idUser);
            builder.HasOne(v => v.Products).WithMany(v => v.CartDetails).HasForeignKey(v => v.idProduct);
        }
    }
}
