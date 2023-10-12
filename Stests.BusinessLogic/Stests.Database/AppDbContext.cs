namespace Stests.Database
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Stests.BusinessLogic.Models;
    using Stests.Database.Helpers;

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
