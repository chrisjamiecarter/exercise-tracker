using System.ComponentModel;

namespace ExerciseTracker.ConsoleApp.Enums;

/// <summary>
/// Supported choices for all menu pages in the application.
/// </summary>
internal enum MenuChoice
{
    [Description("Default")]
    Default,
    [Description("Close application")]
    CloseApplication,
    [Description("Close page")]
    ClosePage,
    [Description("Log an exercise")]
    CreateExercise,
    [Description("Delete an exercise")]
    DeleteExercise,
    [Description("Update an exercise")]
    UpdateExercise,
    [Description("View all exercises")]
    ViewExercises,
}
