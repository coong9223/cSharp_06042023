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
	public class ProducerConfig : IEntityTypeConfiguration<Producer>
	{
		public void Configure(EntityTypeBuilder<Producer> builder)
		{
			builder.HasKey(p => p.idProducer);
			builder.Property(p=>p.nameProducer).HasColumnType("nvarchar(100)");
			builder.Property(p => p.descriptionProducer).HasColumnType("nvarchar(100)");
			builder.Property(p => p.statusProducer).HasColumnType("int");
		}
	}
}
