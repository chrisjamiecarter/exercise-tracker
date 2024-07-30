using ExerciseTracker.Data.Contexts;
using ExerciseTracker.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExerciseTracker.ConsoleApp.Installers;

public class DatabaseInstaller : IInstaller
{
    public void InstallServices(HostApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        builder.Services.AddDbContext<ExerciseTrackerDbContext>(options =>
            options.UseSqlServer(connectionString));

        builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddTransient<IExerciseRepository, ExerciseRepository>();
        builder.Services.AddTransient<IExerciseTypeRepository, ExerciseTypeRepository>();
    }
}
