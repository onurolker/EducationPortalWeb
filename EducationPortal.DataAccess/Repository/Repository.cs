using EducationPortal.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationPortal.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        //DbSet<T> IRepository<T>.Table => throw new NotImplementedException();

        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table() {
            throw new NotImplementedException();}
        public List<T> TList()
        {
            return _context.Set<T>().ToList();
        }

        public void TAdd(T type)
        {
            _context.Set<T>().Add(type);
            _context.SaveChanges();
        }

        public void TUpdate(T type)
        {
            _context.Set<T>().Update(type);
            _context.SaveChanges();
        }

        public void TDelete(T type)
        {
            _context.Set<T>().Remove(type);
            _context.SaveChanges();
        }
        public void TGet(int id)
        {
            _context.Set<T>().Find(id);
            _context.SaveChanges();
        }

        public List<T> TList(string type)   //Category Include
        {
            return _context.Set<T>().Include(type).ToList();
        }

        public IQueryable<T> TAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> TWhere(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> TOrderBy<TKey>(Expression<Func<T, TKey>> orderBy, bool isDesc)
        {
            throw new NotImplementedException();
        }
    }
}
