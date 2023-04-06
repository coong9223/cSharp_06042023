//using _1.DAL.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1.DAL.Configurations
//{
//    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
//    {
//        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
//        {
            

//            builder.ToTable("ProductInCategories");
//            builder.HasKey(t => new { t.CategoryID, t.ProductID });

//            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductInCategories)
//                .HasForeignKey(pc => pc.ProductID);

//            builder.HasOne(t => t.Category).WithMany(pc => pc.ProductInCategories)
//              .HasForeignKey(pc => pc.CategoryID);

//        }
//    }
//}
