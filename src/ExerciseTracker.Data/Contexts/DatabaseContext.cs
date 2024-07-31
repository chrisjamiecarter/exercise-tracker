using ExerciseTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Data.Contexts;

public class DatabaseContext : DbContext
{
    #region Constructors

    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    #endregion
    #region Properties

    public DbSet<ExerciseType> ExerciseTypes { get; set; }

    public DbSet<Exercise> Exercises { get; set; }

    #endregion
    #region Methods

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Required seed data.
        modelBuilder.Entity<ExerciseType>().HasData(
            new ExerciseType
            {
                Id = 1,
                Name = "Cardio"
            },
            new ExerciseType
            {
                Id = 2,
                Name = "Weights"
            }
        );

        base.OnModelCreating(modelBuilder);
    }

    #endregion
}
