using ExerciseTracker.ConsoleApp.Controllers;
using ExerciseTracker.ConsoleApp.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExerciseTracker.ConsoleApp.Installers;

public class AppInstaller : IInstaller
{
    public void InstallServices(IHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            services.AddHostedService<App>();
            services.AddScoped<IExerciseController, ExerciseController>();
            services.AddScoped<IExerciseTypeController, ExerciseTypeController>();
            services.AddTransient<MainMenuPage>();
        });
    }
}
