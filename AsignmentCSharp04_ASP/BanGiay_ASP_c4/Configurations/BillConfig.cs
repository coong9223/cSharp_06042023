using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.Configurations
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
