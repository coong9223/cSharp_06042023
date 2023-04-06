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
	public class RoleConfig : IEntityTypeConfiguration<Role>
	{
		public void Configure(EntityTypeBuilder<Role> builder)
		{
			builder.HasKey(v => v.idRole);
			builder.Property(v => v.nameRole).HasColumnType("nvarchar(100)");
		}
	}
}
