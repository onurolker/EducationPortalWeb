using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Data.Repository
{
    public class GenericRepository<T> where T:class,new()
    {
        ApplicationDbContext context;
        public GenericRepository()
        {
            context = new ApplicationDbContext();
        }
        public List<T> TList()
        {
            return context.Set<T>().ToList();
        }

        public void TAdd(T type)
        {
            context.Set<T>().Add(type);
            context.SaveChanges();
        }

        public void TUpdate(T type)
        {
            context.Set<T>().Update(type);
            context.SaveChanges();
        }

        public void TDelete(T type)
        {
            context.Set<T>().Remove(type);
            context.SaveChanges();
        }
        public void TGet(int id)
        {
            context.Set<T>().Find(id);
            context.SaveChanges();
        }

        public List<T> TList(string type)   //Category Include
        {
            return context.Set<T>().Include(type).ToList();
        }
    }
}
