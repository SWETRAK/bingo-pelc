using BingoPelc.Entities;
using Microsoft.EntityFrameworkCore;

namespace BingoPelc;

public class DomainContextDb: DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<DailyBingo> DailyBingos { get; set; }
    public DbSet<DailyQuestion> DailyQuestions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}