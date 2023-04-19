using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess.Config
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.Property(pi => pi.Id).IsRequired();
            builder.Property(pi => pi.Order).IsRequired();
            builder.Property(pi => pi.ProductId).IsRequired();
            builder.Property(pi => pi.Path).IsRequired();

            builder.HasOne(pi => pi.Product)
                .WithMany()
                .HasForeignKey(pi => pi.ProductId);
        }
    }

}
