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

        builder.HasData(
            CreateQuestion("To co może po piwerku"), 
            CreateQuestion("No kurde stary, zanim ja pojade do domu i wróce to 3 godziny mijają"),
            CreateQuestion("Mam spotkanie samorządu"),
            CreateQuestion("Dojeżdżam na polibudę zaraz"),
            CreateQuestion("Nie stać mnie"),
            CreateQuestion("Przepraszam za spóźnienie"),
            CreateQuestion("Sprawdzam wnioski stypendialne"),
            CreateQuestion("Kiedyś ci oddam bo nie mam teraz"),
            CreateQuestion("Rada wydziału"),
            CreateQuestion("Nie chciało mi się "),
            CreateQuestion("Jak mi zapłacicie za bolta, to mogę opić"),
            CreateQuestion("Urodziny"),
            CreateQuestion("Zachlałem"),
            CreateQuestion("Korki były"),
            CreateQuestion("Więcej czasu na tej jebanej uczelni spędzam niż w domu"),
            CreateQuestion("Chodźmy do Kazika"),
            CreateQuestion("Autobus nie przyjechał"),
            CreateQuestion("Wyjechać z tej mojej wsi"),
            CreateQuestion("Alkochol w plecaku/torbie"),
            CreateQuestion("EHE HE HE"),
            CreateQuestion("Rowerem przyjechałem"),
            CreateQuestion("Czego tak?"),
            CreateQuestion("Kupiłem monstera za x ziko, ale mi się zwróci"),
            CreateQuestion("Ja odpuszczam wykłady, idę do Kazika"),
            CreateQuestion("Ja przyniosę zwolniennie na następne zajęcia")
        );
    }

    private static Question CreateQuestion(string title)
    {
        return new Question
        {
            Id = Guid.NewGuid(),
            Title = title
        };
    }
}