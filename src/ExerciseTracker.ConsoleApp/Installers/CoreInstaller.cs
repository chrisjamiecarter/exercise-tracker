using ExerciseTracker.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExerciseTracker.ConsoleApp.Installers;

public class CoreInstaller : IInstaller
{
    public void InstallServices(HostApplicationBuilder builder)
    {
        builder.Services.AddTransient<IExerciseService, ExerciseService>();
        builder.Services.AddTransient<IExerciseTypeService, ExerciseTypeService>();
    }
}
