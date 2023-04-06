using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agile_and_DAOne_team02.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agile_and_DAOne_team02.Configurations
{
    public class ProductDetailConfig : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.HasKey(v => v.idProDetail);
            builder.HasOne(v => v.Colors).WithMany(v => v.ProductDetails).HasForeignKey(v => v.idColor);
            builder.HasOne(v => v.Materials).WithMany(v => v.ProductDetails).HasForeignKey(v => v.idMaterial);
            builder.HasOne(v => v.Sizes).WithMany(v => v.ProductDetails).HasForeignKey(v => v.idSize);
        }
    }
}
