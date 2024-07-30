﻿using ExerciseTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace ExerciseTracker.Data.Repositories;

public class ExerciseRepository : Repository<Exercise>, IExerciseRepository
{
    #region Constructors

    public ExerciseRepository(DbContext dbContext) : base(dbContext) { }

    #endregion

    public async Task<IReadOnlyList<Exercise>> GetAsync()
    {
        return await Get().ToListAsync();
    }
}
