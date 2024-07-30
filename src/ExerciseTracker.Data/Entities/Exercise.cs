using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExerciseTracker.Data.Entities;

[Table(nameof(Exercise))]
public class Exercise
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public DateTime DateStart { get; set; }

    [Required]
    public DateTime DateEnd { get; set; }

    [Required]
    public TimeSpan Duration { get; set; }

    public string Comments { get; set; } = string.Empty;

    public int ExerciseTypeId  { get; set; }

    public ExerciseType ExerciseType { get; set; }
}
