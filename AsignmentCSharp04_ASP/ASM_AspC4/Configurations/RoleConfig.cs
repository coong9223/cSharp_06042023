using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASM_AspC4.Models;

namespace ASM_AspC4.Configurations
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(v => v.idRole);
            builder.Property(v => v.nameRole).HasColumnType("nvarchar(256)");
        }
    }
}
