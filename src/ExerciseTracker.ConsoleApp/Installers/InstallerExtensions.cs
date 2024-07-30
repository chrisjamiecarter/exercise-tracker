using Microsoft.Extensions.Hosting;

namespace ExerciseTracker.ConsoleApp.Installers;

public static class InstallerExtensions
{
    public static void InstallServicesInAssembly(this HostApplicationBuilder builder)
    {
        var installers = typeof(Program).Assembly.ExportedTypes.
            Where(x => typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).
            Select(Activator.CreateInstance).
            Cast<IInstaller>().
            ToList();

        installers.ForEach(installer => installer.InstallServices(builder));
    }
}
