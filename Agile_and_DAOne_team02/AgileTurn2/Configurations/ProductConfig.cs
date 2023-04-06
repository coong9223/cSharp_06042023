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
	public class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(v => v.idProduct);
			builder.Property(v => v.nameProduct).HasColumnType("nvarchar(100)");
			builder.Property(v => v.typeProduct).HasColumnType("nvarchar(100)");
			builder.Property(v => v.descriptionProduct).HasColumnType("nvarchar(100)");
			builder.Property(v => v.statusProduct).HasColumnType("int");
		}
	}
}
