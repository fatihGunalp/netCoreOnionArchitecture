using Microsoft.EntityFrameworkCore;
using Onion.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Repository.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=OnionArchitectureDB;uid=sa;pwd=123");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}
