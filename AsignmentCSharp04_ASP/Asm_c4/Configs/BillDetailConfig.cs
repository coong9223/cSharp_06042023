using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Asm_c4.Models;

namespace Asm_c4.Configs
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
