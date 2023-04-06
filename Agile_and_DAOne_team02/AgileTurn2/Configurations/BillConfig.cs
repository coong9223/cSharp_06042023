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
    public class BillConfig : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(v => v.idBill);
            builder.HasOne(v => v.Staffs).WithMany(v => v.Bills).HasForeignKey(v => v.idStaff);
            builder.HasOne(v => v.Customers).WithMany(v => v.Bills).HasForeignKey(v => v.idCustomer);
            
            
        }
    }
}
