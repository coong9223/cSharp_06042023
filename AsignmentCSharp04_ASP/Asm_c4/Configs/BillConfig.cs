using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Asm_c4.Models;

namespace Asm_c4.Configs
{
    public class BillConfig : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(v => v.idBill);
            builder.HasOne(v => v.Users).WithMany(v => v.Bills).HasForeignKey(v => v.idUser);
            builder.Property(v => v.statusBill).HasColumnType("int").IsRequired();
        }
    }
}
