using BingoPelc.Entities;
using BingoPelc.Entities.Properties;
using Microsoft.EntityFrameworkCore;

namespace BingoPelc;

public class DomainContextDb: DbContext
{
    private readonly IConfiguration _configuration;

    public DomainContextDb(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<DailyBingo> DailyBingos { get; set; }
    public DbSet<DailyQuestion> DailyQuestions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("WebApiDatabase"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new UserEntityConfiguration().Configure(modelBuilder.Entity<User>());
        new QuestionEntityConfiguration().Configure(modelBuilder.Entity<Question>());
        new DailyQuestionEntityConfiguration().Configure(modelBuilder.Entity<DailyQuestion>());
        new DailyBingoEntityConfiguration().Configure(modelBuilder.Entity<DailyBingo>());
    }
}