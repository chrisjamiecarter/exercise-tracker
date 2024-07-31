using ExerciseTracker.Data.Contexts;
using ExerciseTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace ExerciseTracker.Data.Repositories;

public class ExerciseRepository : Repository<Exercise>, IExerciseRepository
{
    #region Constructors

    public ExerciseRepository(DatabaseContext dbContext) : base(dbContext) { }

    #endregion

    public async Task<IReadOnlyList<Exercise>> GetAsync()
    {
        return await Get()
            .Include(x => x.ExerciseType)
            .OrderBy(o => o.DateStart)
            .ThenBy(o => o.DateEnd)
            .ToListAsync();
    }
}
