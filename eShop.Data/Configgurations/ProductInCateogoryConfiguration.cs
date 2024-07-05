using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Data.Configgurations
{
    public class ProductInCateogoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCateogories");
            builder.HasKey(t =>  new {t.ProductId, t.CategoryId});
            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductInCategories).HasForeignKey(t => t.ProductId);


            builder.HasOne(c => c.Category).WithMany(pc => pc.ProductInCategories).HasForeignKey(t => t.CategoryId);
        }
    }
}
