using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agile_and_DAOne_team02.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Agile_and_DAOne_team02.Configurations
{
	public class MetarialConfig : IEntityTypeConfiguration<Material>
	{
		public void Configure(EntityTypeBuilder<Material> builder)
		{
			builder.HasKey(p => p.idMaterial);
			builder.Property(p => p.nameMaterial).HasColumnType("nvarchar(100)");
			builder.Property(p => p.descriptionMaterial).HasColumnType("nvarchar(100)");
			builder.Property(p => p.statusMaterial).HasColumnType("nvarchar(100)");
		}
	}
}
