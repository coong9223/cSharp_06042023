using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Asm_c4.Models;

namespace Asm_c4.Configs
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(v => v.idUser);
            builder.Property(v => v.nameUser).HasColumnType("nvarchar(256)");
            builder.Property(v => v.nameRole).HasColumnType("nvarchar(256)");
            builder.Property(v => v.passwordUser).HasColumnType("nvarchar(256)");
        }
    }
}
