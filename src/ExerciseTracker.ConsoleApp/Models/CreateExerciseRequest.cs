using ExerciseTracker.Data.Entities;

namespace ExerciseTracker.ConsoleApp.Models;

internal class CreateExerciseRequest
{
    internal DateTime DateStart { get; set; }

    internal DateTime DateEnd { get; set; }

    internal TimeSpan Duration { get; set; }

    internal string Comments { get; set; } = string.Empty;

    internal ExerciseType ExerciseType { get; set; }
}
