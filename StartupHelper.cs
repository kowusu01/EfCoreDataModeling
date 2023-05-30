
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EfCoreDataModeling
{
    public class StartupHelper
    {

        public static void ConfigureDatabase(IHostBuilder builder, string connectionString)
        {
            builder.ConfigureServices(services =>
            {
                services.AddDbContext<AppDbContext>(
                options => options
                    .UseNpgsql(connectionString)
                    .EnableSensitiveDataLogging()  // for debugging and development ONLY!
                    .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                );
            }

            );
        }



    }
}
