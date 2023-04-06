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
	public class SizeConfig : IEntityTypeConfiguration<Size>
	{
		public void Configure(EntityTypeBuilder<Size> builder)
		{
			builder.HasKey(p => p.idSize);
			builder.Property(p=>p.typeSize).HasColumnType("varchar(100)");
			builder.Property(v => v.statusSize).HasColumnType("int");
		}
	}
}
