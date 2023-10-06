namespace Stests.BusinessLogic.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    internal class AppDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        protected AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add the Postgres Extension for UUID generation.
            modelBuilder.HasPostgresExtension("uuid-ossp");

            // Define configurations.
            //modelBuilder.ApplyConfiguration(new UserGroupRelations());
            //modelBuilder.ApplyConfiguration(new TypeConfiguration());
            //modelBuilder.ApplyConfiguration(new ThreatConfiguration());
            //modelBuilder.ApplyConfiguration(new ClassificationConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("PostgresConnectionString"));
        }

        public DbSet<Users> users;

        public DbSet<UserRoles> roles;

        public DbSet<UsersInfo> userInfo;

        public DbSet<TestSessions> testSessions;

        public DbSet<UserGroupRelations> userGroupRelation;

        public DbSet<UserGroups> userGroups;

        public DbSet<Tests> tests;

        public DbSet<Grades> grades;

        public DbSet<UserAnswers> usersAnswers;

        public DbSet<CorrectAnswers> correctAnswers;
    }
}
