using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.Configurations
{
    public class UserConfig:IEntityTypeConfiguration<User>
    {
       
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(v => v.idUser);
            builder.HasOne(v => v.Roles).WithMany(v => v.Users).HasForeignKey(v => v.idRole);
            builder.Property(v => v.nameUser).HasColumnType("nvarchar(256)");
            builder.Property(v => v.nameRole).HasColumnType("nvarchar(256)");
            builder.Property(v => v.passwordUser).HasColumnType("nvarchar(256)");
        }
    }
}
