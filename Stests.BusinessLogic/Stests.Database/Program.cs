using Stests.BusinessLogic.Models;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Stests.Database
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("C:\\Users\\Alex\\Source\\Repos\\stests-desktop\\Stests.BusinessLogic\\Stests.Database\\appsettings.json")
            .AddEnvironmentVariables()
            .Build();

            Log.Logger = new LoggerConfiguration()
                        .ReadFrom
                        .Configuration(config)
                        .CreateLogger();

            Log.Information("Чтение конфигурации.");

            AppDbContext context = new AppDbContext(config);
        }
    }
}