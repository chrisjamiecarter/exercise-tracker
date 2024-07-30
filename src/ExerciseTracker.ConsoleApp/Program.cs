using System.Runtime.CompilerServices;
using ExerciseTracker.ConsoleApp.Installers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ExerciseTracker.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);

        // Add services to the container.
        builder.InstallServicesInAssembly();

        using var app = builder.Build();

        try
        {
            app.Run();            
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
