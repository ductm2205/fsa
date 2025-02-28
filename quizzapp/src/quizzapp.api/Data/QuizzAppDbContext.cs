using System;
using Microsoft.EntityFrameworkCore;
using quizzapp.api.Model.Common;

namespace quizzapp.api.Data;

public class QuizzAppDbContext(DbContextOptions<QuizzAppDbContext> options) : DbContext(options)
{

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Quizz>(quizz =>
        {
            quizz
            .HasMany(quizz => quizz.Questions)
            .WithOne(question => question.Quizz)
            .HasForeignKey(question => question.QuizzId)
            .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Question>(question =>
        {
            question
            .HasMany(question => question.Answers)
            .WithOne(answer => answer.Question)
            .HasForeignKey(answer => answer.QuestionId)
            .OnDelete(DeleteBehavior.Cascade);
        });

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Quizz> Quizzes { get; set; }

    public DbSet<Question> Questions { get; set; }

    public DbSet<Answer> Answers { get; set; }

}
