using Microsoft.Extensions.Hosting;

namespace ExerciseTracker.ConsoleApp;

internal class App : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Hello World!");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
