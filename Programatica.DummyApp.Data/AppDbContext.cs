using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Programatica.DummyApp.Data.Models;
using Programatica.Framework.Data.Context;


namespace Programatica.DummyApp.Data
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
}
