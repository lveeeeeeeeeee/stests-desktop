using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Stests.Database
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder optionsBuilder = new();
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("C:\\Users\\Alex\\Source\\Repos\\stests-desktop\\Stests.BusinessLogic\\Stests.Database\\appsettings.json")
            .AddEnvironmentVariables()
            .Build();

            return new AppDbContext(config);
        }
    }
}
