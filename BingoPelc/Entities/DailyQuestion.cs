namespace BingoPelc.Entities;

public class DailyQuestion
{
    public Guid Id { get; set; }

    public virtual DailyBingo DailyBingo { get; set; }
    public Guid DailyBingoId { get; set; }
    public int Index { get; set; }
    public virtual Question Question { get; set; }
    public Guid QuestionId { get; set; }

    public bool Checked { get; set; }
}