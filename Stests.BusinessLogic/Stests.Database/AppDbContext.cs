namespace Stests.Database
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Stests.BusinessLogic.Models;

    public class AppDbContext : DbContext
    {
        protected IConfiguration _configuration;

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersInfo>(entity =>
            {
                entity.HasIndex(e => e.Login).IsUnique();
            });
            modelBuilder.Entity<UserGroups>(entity =>
            {
                entity.HasIndex(e => e.Name).IsUnique();
            });
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Postgres"));
        }

        public DbSet<Users> users => Set<Users>();

        public DbSet<UserRoles> roles => Set<UserRoles>();

        public DbSet<UsersInfo> user_info => Set<UsersInfo>();

        public DbSet<TestSessions> test_sessions => Set<TestSessions>();

        public DbSet<UserGroupRelations> user_group_relation => Set<UserGroupRelations>();

        public DbSet<UserGroups> user_groups => Set<UserGroups>();

        public DbSet<Tests> tests => Set<Tests>();

        public DbSet<Grades> grades => Set<Grades>();

        public DbSet<UserAnswers> users_answers => Set<UserAnswers>();

        public DbSet<CorrectAnswers> correct_answers => Set<CorrectAnswers>();
    }
}
