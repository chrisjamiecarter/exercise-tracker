using ExerciseTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Data.Contexts;

public class ExerciseTrackerDbContext : DbContext
{
    #region Constructors

    public ExerciseTrackerDbContext()
    {
        
    }
    public ExerciseTrackerDbContext(DbContextOptions<ExerciseTrackerDbContext> options) : base(options)
    {
        
    }

    #endregion
    #region Properties

    public DbSet<ExerciseType> ExerciseTypes { get; set; }

    public DbSet<Exercise> Exercises { get; set; }

    #endregion
}
