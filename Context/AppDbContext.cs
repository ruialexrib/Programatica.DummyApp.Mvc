using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Programatica.DummyApp.Mvc.Models;
using Programatica.Framework.Data.Context;

namespace Programatica.DummyApp.Mvc.Context
{
    public class AppDbContext : BaseDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed data
            modelBuilder.Entity<User>().HasData(
                    new User { Id = 1, Name = "User1", Email = "user1@mail.com", Password = "123" },
                    new User { Id = 2, Name = "User2", Email = "user2@mail.com", Password = "123" }
            );
        }

    }

    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public IConfigurationRoot Configuration { get; set; }

        AppDbContext IDesignTimeDbContextFactory<AppDbContext>.CreateDbContext(string[] args)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                .EnableDetailedErrors();

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
