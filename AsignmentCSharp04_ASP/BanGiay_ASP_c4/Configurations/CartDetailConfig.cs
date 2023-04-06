using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.Configurations
{
    public class CartDetailConfig : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.HasKey(v => v.idCDetail);
            builder.HasOne(v => v.Carts).WithMany(v => v.CartDetails).HasForeignKey(v => v.idUserFK);
            builder.HasOne(v => v.Products).WithMany(v => v.CartDetails).HasForeignKey(v => v.idProduct);
        }
    }
}
