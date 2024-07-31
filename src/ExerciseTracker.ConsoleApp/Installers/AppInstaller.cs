using ExerciseTracker.ConsoleApp.Configurations;
using ExerciseTracker.ConsoleApp.Controllers;
using ExerciseTracker.ConsoleApp.Views;
using ExerciseTracker.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExerciseTracker.ConsoleApp.Installers;

public class AppInstaller : IInstaller
{
    public void InstallServices(IHostBuilder builder)
    {
        builder.ConfigureServices((hostContext, services) =>
        {
            services.AddHostedService<App>();
            services.AddScoped<IExerciseController, ExerciseController>();
            services.AddScoped<IExerciseTypeController, ExerciseTypeController>();
            services.AddOptions<DatabaseOptions>().Bind(hostContext.Configuration.GetSection("DatabaseOptions"));
            services.AddScoped<ISeederService, SeederService>();
            services.AddTransient<MainMenuPage>();
        });
    }
}
