using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASM_AspC4.Models;

namespace ASM_AspC4.Configurations
{
    public class MetarialConfig : IEntityTypeConfiguration<Metarial>
    {
        public void Configure(EntityTypeBuilder<Metarial> builder)
        {
            builder.HasKey(v => v.idMetarial);
            builder.Property(v => v.nameMetarial).HasColumnType("nvarchar(100)");
        }
    }
}
