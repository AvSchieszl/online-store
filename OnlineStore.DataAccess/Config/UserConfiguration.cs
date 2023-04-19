using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(o => o.Id).IsRequired();
            builder.Property(u => u.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(50).IsRequired();
            builder.Property(u => u.CivilianId).HasMaxLength(20).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.PhoneNumber).HasMaxLength(20).IsRequired();
            builder.Property(u => u.DateOfBirth).HasColumnType("date").IsRequired();
            builder.Property(u => u.Role).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();
        }
    }
}
