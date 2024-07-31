using ExerciseTracker.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExerciseTracker.ConsoleApp.Installers;

public class CoreInstaller : IInstaller
{
    public void InstallServices(IHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            services.AddScoped<IExerciseService, ExerciseService>();
            services.AddScoped<IExerciseTypeService, ExerciseTypeService>();
        });
    }
}
