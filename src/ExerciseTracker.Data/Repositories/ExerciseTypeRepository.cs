using ExerciseTracker.Data.Contexts;
using ExerciseTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace ExerciseTracker.Data.Repositories;

public class ExerciseTypeRepository : Repository<ExerciseType>, IExerciseTypeRepository
{
    #region Constructors

    public ExerciseTypeRepository(DatabaseContext dbContext) : base(dbContext) { }

    #endregion

    public async Task<IReadOnlyList<ExerciseType>> GetAsync()
    {
        return await Get().ToListAsync();
    }
}
