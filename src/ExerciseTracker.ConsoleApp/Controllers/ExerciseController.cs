using ExerciseTracker.ConsoleApp.Models;
using ExerciseTracker.Data.Entities;
using ExerciseTracker.Services;

namespace ExerciseTracker.ConsoleApp.Controllers;

internal class ExerciseController
{
    private readonly IExerciseService _exerciseService;
    private readonly IExerciseTypeService _exerciseTypeService;

    public ExerciseController(IExerciseService exerciseService, IExerciseTypeService exerciseTypeService)
    {
        _exerciseService = exerciseService;
        _exerciseTypeService = exerciseTypeService;
    }

    public async Task<bool> CreateAsync(CreateExerciseRequest request)
    {
        // DateTime.Now.AddHours(-2);
        // DateTime.Now;
        // $"Added by ExerciseController @ '{DateTime.Now}'",

        var exercise = new Exercise
        {
            DateStart = request.DateStart,
            DateEnd = request.DateEnd,
            Duration = request.DateEnd - request.DateStart,
            Comments = request.Comments,
            ExerciseType = request.ExerciseType,
        };

        return await _exerciseService.CreateAsync(exercise);
    }

    public async Task<bool> DeleteExerciseAsync(int id)
    {
        return await _exerciseService.DeleteAsync(id);
    }

    public async Task<Exercise?> ReturnExerciseAsync(int id)
    {
        return await _exerciseService.ReturnAsync(id);
    }

    public async Task<IReadOnlyList<Exercise>> ReturnExercisesAsync()
    {
        return await _exerciseService.ReturnAsync();
    }

    public async Task<bool> UpdateAsync(UpdateExerciseRequest request)
    {
        var exercise = new Exercise
        {
            Id = request.Id,
            DateStart = request.DateStart,
            DateEnd = request.DateEnd,
            Duration = request.DateEnd - request.DateStart,
            Comments = request.Comments,
            ExerciseType = request.ExerciseType,
        };

        return await _exerciseService.UpdateAsync(exercise);
    }
}
