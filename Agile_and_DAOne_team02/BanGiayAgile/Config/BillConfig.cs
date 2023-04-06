using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BanGiayAgile.ViewModels;

namespace BanGiayAgile.Config
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
