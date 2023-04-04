using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BingoPelc.Entities.Properties;

public class DailyQuestionEntityConfiguration: IEntityTypeConfiguration<DailyQuestion>
{
    public void Configure(EntityTypeBuilder<DailyQuestion> builder)
    {
        builder.ToTable("daily_questions");

        builder.Property(dq => dq.Index)
            .IsRequired();

        builder.Property(dq => dq.Checked)
            .IsRequired()
            .HasDefaultValue(false);

        builder.HasOne<DailyBingo>(dq => dq.DailyBingo)
            .WithMany(db => db.DailyQuestions)
            .HasForeignKey(dq => dq.DailyBingoId)
            .IsRequired();

        builder.HasOne<Question>(dq => dq.Question)
            .WithMany()
            .HasForeignKey(dq => dq.QuestionId)
            .IsRequired();
    }
}