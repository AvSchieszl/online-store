using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Config
{
    public class StockEventConfiguration : IEntityTypeConfiguration<StockEvent>
    {
        public void Configure(EntityTypeBuilder<StockEvent> builder)
        {
            builder.Property(se => se.Id).IsRequired();
            builder.Property(se => se.StockId).IsRequired();
            builder.Property(se => se.Type).IsRequired();
            builder.Property(se => se.Reason).IsRequired();
            builder.Property(se => se.Quantity).IsRequired();
            builder.Property(se => se.CreatedAt).IsRequired();

            builder.HasOne(se => se.Stock)
                .WithMany()
                .HasForeignKey(se => se.StockId);
        }
    }
}
