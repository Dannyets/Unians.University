using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using University.DAL.Models;

namespace University.DAL
{
    public class UniversityDbContext : BaseMySqlDbContext
    {
        public UniversityDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        public DbSet<DbUniversity> Universities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbUniversity>().HasKey(p => p.Id);

            modelBuilder.Entity<DbUniversity>().HasIndex(p => p.Name);
        }
    }
}
