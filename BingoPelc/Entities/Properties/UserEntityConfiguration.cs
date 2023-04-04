using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BingoPelc.Entities.Properties;

public class UserEntityConfiguration: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.HashedPassword)
            .IsRequired();

        builder.Property(u => u.Nickname)
            .IsRequired()
            .HasMaxLength(20);
    }
}