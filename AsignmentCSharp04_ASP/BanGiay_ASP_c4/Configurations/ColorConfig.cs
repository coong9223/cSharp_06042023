using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.Configurations
{
    public class ColorConfig : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(v => v.idColor);
            builder.Property(v => v.nameColor).HasColumnType("nvarchar(100)");
        }
    }
}
