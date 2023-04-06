using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASM_AspC4.Models;


namespace ASM_AspC4.Configurations
{
    public class BillDetailConfig : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.HasKey(v => v.idBDetail);
            builder.HasOne(v => v.Bills).WithMany(v => v.BillDetails).HasForeignKey(v => v.idBDetail);
            builder.HasOne(v => v.Products).WithMany(v => v.BillDetails).HasForeignKey(v => v.idProduct);
            builder.Property(v => v.quantity).HasColumnType("int");
        }
    }
}
