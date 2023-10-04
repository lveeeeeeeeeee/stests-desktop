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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("PostgresConnectionString"));
        }

        public DbSet<User> users;

        public DbSet<UserRole> roles;

        public DbSet<UserInfo> userInfo;

        public DbSet<TestSession> testSessions;

        public DbSet<UserGroupRelation> userGroupRelation;

        public DbSet<UserGroup> userGroups;

        public DbSet<Test> Tests;

        public DbSet<Grade> Grades;

        public DbSet<UserAnswers> usersAnswers;

        public DbSet<CorrectAnswers> correctAnswers;
    }
}
