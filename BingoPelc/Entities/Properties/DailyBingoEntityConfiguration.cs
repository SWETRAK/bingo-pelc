using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BingoPelc.Entities.Properties;

public class DailyBingoEntityConfiguration: IEntityTypeConfiguration<DailyBingo>
{
    public void Configure(EntityTypeBuilder<DailyBingo> builder)
    {
        builder.ToTable("daily_bingo");

        builder.Property(db => db.Date)
            .HasDefaultValue(DateTime.Now)
            .IsRequired();

        builder.HasOne<User>(db => db.User)
            .WithMany()
            .HasForeignKey(db => db.UserId)
            .IsRequired();

        builder.HasMany<DailyQuestion>(db => db.DailyQuestions)
            .WithOne(dq => dq.DailyBingo)
            .HasForeignKey(dq => dq.DailyBingoId);

    }
}