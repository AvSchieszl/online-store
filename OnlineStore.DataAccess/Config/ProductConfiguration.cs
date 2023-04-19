using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(60).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Thumbnail).IsRequired();
            builder.Property(p => p.UnitPrice).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(p => p.CategoryId).IsRequired();
            builder.Property(p => p.CreatedById).IsRequired();
            builder.Property(p => p.CreatedAt).IsRequired();
            builder.Property(p => p.IsDeleted).IsRequired();

            builder.HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId);

            builder.HasOne(p => p.Creator)
                .WithMany()
                .HasForeignKey(p => p.CreatedById);
        }
    }
}
