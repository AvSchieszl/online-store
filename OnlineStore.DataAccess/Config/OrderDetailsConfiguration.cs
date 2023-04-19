using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Config
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.Property(od => od.Id).IsRequired();
            builder.Property(od => od.OrderId).IsRequired();
            builder.Property(od => od.ProductId).IsRequired();
            builder.Property(od => od.UnitPrice).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(od => od.Quantity).IsRequired();

            builder.HasOne(od => od.Order)
                .WithMany()
                .HasForeignKey(od => od.OrderId);

            builder.HasOne(od => od.Product)
                .WithMany()
                .HasForeignKey(od => od.ProductId);
        }
    }
}
