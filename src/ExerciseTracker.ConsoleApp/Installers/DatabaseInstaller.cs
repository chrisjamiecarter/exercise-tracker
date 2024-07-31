using System.Reflection;
using ExerciseTracker.Data.Contexts;
using ExerciseTracker.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExerciseTracker.ConsoleApp.Installers;

public class DatabaseInstaller : IInstaller
{
    public void InstallServices(IHostBuilder builder)
    {
        builder.ConfigureServices((hostContext, services) =>
        {
            var connectionString = hostContext.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(connectionString));
            
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IExerciseRepository, ExerciseRepository>();
            services.AddScoped<IExerciseTypeRepository, ExerciseTypeRepository>();           
        });
    }
}
