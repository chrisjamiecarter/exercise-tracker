using ExerciseTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace ExerciseTracker.Data.Repositories;

public class ExerciseTypeRepository : Repository<ExerciseType>, IExerciseTypeRepository
{
    #region Constructors

    public ExerciseTypeRepository(DbContext dbContext) : base(dbContext) { }

    #endregion

    public async Task<IReadOnlyList<ExerciseType>> GetAsync()
    {
        return await Get().ToListAsync();
    }
}
