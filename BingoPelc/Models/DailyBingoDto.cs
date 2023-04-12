namespace BingoPelc.Models;

public class DailyBingoDto
{
    public string Id { get; set; }

    public IEnumerable<DailyQuestionDto> DailyQuestions { get; set; }

    public DateTime Date { get; set; }

    public bool Win { get; set; }
}