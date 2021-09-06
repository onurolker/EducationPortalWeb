using EducationPortal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUserViewModel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<EducationCategoriesViewModel> EducationCategoriesViewModels { get; set; }
        public DbSet<EducationViewModel> EducationViewModels { get; set; }
        public DbSet<EducationDetailsViewModel> EducationDetailsViewModels { get; set; }
        public DbSet<CustomUserViewModel> CustomUserViewModel { get; set; }
        public DbSet<EducationUsersAndEducation> EducationUsersAndEducation { get; set; }

    }
}
