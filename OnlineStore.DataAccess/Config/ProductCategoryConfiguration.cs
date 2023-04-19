using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Config
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.Property(pc => pc.Id).IsRequired();
            builder.Property(pc => pc.Name).HasMaxLength(60).IsRequired();
            builder.Property(pc => pc.Description).IsRequired();
            builder.Property(pc => pc.Image).IsRequired();
            builder.Property(pc => pc.IsDeleted).IsRequired();
        }
    }
}
