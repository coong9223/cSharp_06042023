using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agile_and_DAOne_team02.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agile_and_DAOne_team02.Configurations
{
    public class StaffConfig : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(v => v.idStaff);
            builder.HasOne(v => v.Roles).WithMany(v => v.Staffs).HasForeignKey(v => v.idRole);
        }
    }
}
