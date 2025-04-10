using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabats.RepositoryLayer.Entities;

namespace Talabats.RepositoryLayer.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(n => n.Name).IsRequired().HasMaxLength(100);
            builder.Property(n => n.Description).IsRequired().HasMaxLength(100);
            builder.Property(n => n.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasOne(b => b.productBrand).WithMany().HasForeignKey(b => b.productBrandId);
            builder.HasOne(b => b.productType).WithMany().HasForeignKey(b => b.productTypeId);

        }
    }
}
