using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lab4.Models;

namespace Lab4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Province>().Property(m => m.ProvinceCode).IsRequired();

            builder.Entity<Province>().ToTable("Province");
            builder.Entity<City>().ToTable("City");
            
            builder.Seed();
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Province> Provinces { get; set; }
    }
}
