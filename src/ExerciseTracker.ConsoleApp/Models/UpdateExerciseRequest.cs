using ExerciseTracker.Data.Entities;

namespace ExerciseTracker.ConsoleApp.Models;

internal class UpdateExerciseRequest
{
    internal int Id { get; set; }

    internal DateTime DateStart { get; set; }

    internal DateTime DateEnd { get; set; }

    internal string Comments { get; set; } = string.Empty;

    internal ExerciseType ExerciseType { get; set; }
}
