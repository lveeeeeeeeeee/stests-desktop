using Microsoft.Extensions.Configuration;

namespace Stests.Database
{
    public class DefaultDbContextFactory
    {
        public AppDbContext CreateDbContext()
        {
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("C:\\Users\\Alex\\Source\\Repos\\stests-desktop\\Stests.BusinessLogic\\Stests.Database\\appsettings.json")
            .AddEnvironmentVariables()
            .Build();

            return new AppDbContext(config);
        }
    }
}
