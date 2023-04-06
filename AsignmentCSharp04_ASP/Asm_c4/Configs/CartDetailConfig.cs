using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Asm_c4.Models;

namespace Asm_c4.Configs
{
    public class CartDetailConfig : IEntityTypeConfiguration<CartDetail>
    {
        void IEntityTypeConfiguration<CartDetail>.Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.HasKey(v => v.idCDetail);
            builder.HasOne(v => v.Carts).WithMany(v => v.CartDetails).HasForeignKey(v => v.idUser);
            builder.HasOne(v => v.Products).WithMany(v => v.CartDetails).HasForeignKey(v => v.idProduct);
        }
    }
}
