using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.Configurations
{
    public class BillDetailConfig : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.HasKey(v => v.idBDetail);
            builder.HasOne(v => v.Bills).WithMany(v => v.BillDetails).HasForeignKey(v => v.idBill);
            builder.HasOne(v => v.Products).WithMany(v => v.BillDetails).HasForeignKey(v => v.idProduct);
            builder.Property(v => v.quantity).HasColumnType("int");
        }
    }
}
