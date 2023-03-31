namespace BingoPelc.Entities;

public class DailyBingo
{
    public Guid Id { get; set; }

    public virtual User User { get; set; }
    public Guid UserId { get; set; }

    public virtual IEnumerable<DailyQuestion> DailyQuestions { get; set; }

    public DateTime Date { get; set; }
}