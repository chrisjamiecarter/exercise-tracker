using ExerciseTracker.ConsoleApp.Installers;
using Microsoft.Extensions.Hosting;

namespace ExerciseTracker.ConsoleApp;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args);

        // Add services to the container.
        builder.InstallServicesInAssembly();

        await builder.RunConsoleAsync();                    
    }
}
