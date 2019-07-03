using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Unians.University.Data.Models;

namespace Unians.University.Data.Context
{
    public class UniversityDbContext : BaseMySqlDbContext
    {
        public UniversityDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        public DbSet<DbUniversity> Universities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: REMOVE ONCE NEW DATABASE IS ADDED
            optionsBuilder.UseInMemoryDatabase("unians_university");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbUniversity>().HasKey(p => p.Id);

            modelBuilder.Entity<DbUniversity>().HasIndex(p => p.Name);

            //TODO: REMOVE ONCE NEW DATABASE IS ADDED
            modelBuilder.Entity<DbUniversity>().HasData(new List<DbUniversity>
            {
                new DbUniversity
                {
                    Id = 1,
                    Name = "טכניון",
                    CreatedAt = DateTime.UtcNow,
                    LastUdpatedAt = DateTime.UtcNow
                }
            });
        }
    }
}
