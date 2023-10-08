namespace Stests.BusinessLogic.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    internal class AppDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        protected AppDbContext(IConfiguration configuration)
        {
            Database.EnsureCreated();
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("PostgresConnectionString"));
        }

        public DbSet<Users> Users => Set<Users>();

        public DbSet<UserRoles> Roles => Set<UserRoles>();

        public DbSet<UsersInfo> UserInfo => Set<UsersInfo>();

        public DbSet<TestSessions> TestSessions => Set<TestSessions>();

        public DbSet<UserGroupRelations> UserGroupRelation => Set<UserGroupRelations>();

        public DbSet<UserGroups> UserGroups => Set<UserGroups>();

        public DbSet<Tests> Tests => Set<Tests>();

        public DbSet<Grades> Grades => Set<Grades>();

        public DbSet<UserAnswers> UsersAnswers => Set<UserAnswers>();

        public DbSet<CorrectAnswers> CorrectAnswers => Set<CorrectAnswers>();
    }
}
