
using EducationPortal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationPortal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)  //need Configuration.FileExtension
               .AddJsonFile("appsettings.json") //need Configuration.Json
               .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            }

        }
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //    : base(options)
        //{
        //}

        //public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<EducationCategories> EducationCategories { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationDetails> EducationDetails { get; set; }

        //public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<EducationUserAndEducation> EducationUserAndEducations { get; set; }

    }
}
