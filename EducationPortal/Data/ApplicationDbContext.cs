using EducationPortal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUserViewModel>
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json")
               .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            }

        }
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //    : base(options)
        //{
        //}

        //public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<EducationCategoriesViewModel> EducationCategoriesViewModels { get; set; }
        public DbSet<EducationViewModel> EducationViewModels { get; set; }
        public DbSet<EducationDetailsViewModel> EducationDetailsViewModels { get; set; }
        public DbSet<CustomUserViewModel> CustomUserViewModel { get; set; }
        public DbSet<EducationUsersAndEducation> EducationUsersAndEducation { get; set; }

    }
}
