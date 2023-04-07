using BingoPelc.Migrations;
using Microsoft.AspNetCore.Identity;
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
        
        builder.HasData(AddPassword("kamilpietrak123@gmail.com", "SWETRAK", "Ssmr1234"));
    }

    private static User AddPassword(string email, string nickname, string password)
    {
        var passwordHasher = new PasswordHasher<User>();
        var user = new User
        {
            Id = Guid.NewGuid(),
            Email = email,
            Nickname = nickname,
        };
        user.HashedPassword = passwordHasher.HashPassword(user, password);
        return user;
    }
}