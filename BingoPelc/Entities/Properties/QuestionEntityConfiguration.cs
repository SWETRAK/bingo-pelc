using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BingoPelc.Entities.Properties;

public class QuestionEntityConfiguration: IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.ToTable("question");

        builder.Property(q => q.Title)
            .IsRequired();
    }
}