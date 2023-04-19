using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Config
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.Property(s => s.Id).IsRequired();
            builder.Property(s => s.ProductId).IsRequired();
            builder.Property(s => s.Quantity).IsRequired();

            builder.HasOne(s => s.Product)
                .WithMany()
                .HasForeignKey(s => s.ProductId);
        }
    }
}
