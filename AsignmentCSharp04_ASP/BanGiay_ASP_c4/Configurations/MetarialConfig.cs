using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.Configurations
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
