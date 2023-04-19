using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.Id).IsRequired();
            builder.Property(o => o.ClerkId).IsRequired();
            builder.Property(o => o.CustomerId).IsRequired();
            builder.Property(o => o.CreatedAt).IsRequired();
            builder.Property(o => o.IsDeleted).IsRequired();

            builder.HasOne(o => o.Clerk)
                .WithMany()
                .HasForeignKey(o => o.ClerkId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(o => o.Customer)
                .WithMany()
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
