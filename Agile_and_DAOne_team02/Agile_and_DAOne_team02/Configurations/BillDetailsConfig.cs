using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Agile_and_DAOne_team02.ViewModels;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agile_and_DAOne_team02.Configurations
{
    public class BillDetailsConfig : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.HasKey(v => v.idBillDetail);
            builder.HasOne(v => v.Bills).WithMany(v => v.BillDetail).HasForeignKey(v => v.idBill);
            builder.HasOne(v => v.ProductDetails).WithMany(v =>v.BillDetails).HasForeignKey(v => v.idProDetail);
        }
    }
}
