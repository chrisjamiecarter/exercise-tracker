using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExerciseTracker.ConsoleApp.Installers;

public class AppInstaller : IInstaller
{
    public void InstallServices(HostApplicationBuilder builder)
    {
        builder.Services.AddHostedService<App>();
    }
}
