using EducationPortal.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            string[] list = new string[] { "Online", "Sınıf içi eğitim", "Kitap", "Sunum", "Makale", "Mini proje" };
            if (!context.EducationCategoriesViewModels.Any())
            {
               
                foreach (var item in list)
                { var category = new EducationCategoriesViewModel();
                    category.CategoryName = item;
                    context.EducationCategoriesViewModels.Add(category);
                    context.SaveChanges();

                }
                 // DB has been seeded
            }


            //if (!context.Roles.Any())
            //{
            //    string[] rolename = new string[] { "1", "2"};
            //    foreach (var item in rolename)
            //    {
            //        context.Roles.Add(new IdentityRole()
            //        {
            //            Name = item
            //        });
            //        context.SaveChanges();
            //    }
            //}

            context.SaveChanges();
        }
    }
}
