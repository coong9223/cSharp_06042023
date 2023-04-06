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
    public class BillDetailConfig : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.HasKey(v => v.idBillDetail);
            builder.HasOne(v => v.Bills).WithMany(v => v.BillDetails).HasForeignKey(v => v.idBill);
            builder.HasOne(v => v.Product).WithMany(v => v.BillDetails).HasForeignKey(v => v.idPro);
        }
    }
}
